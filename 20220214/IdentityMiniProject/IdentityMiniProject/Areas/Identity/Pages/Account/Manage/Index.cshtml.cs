using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IdentityMiniProject.Attributes;
using IdentityMiniProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityMiniProject.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWebHostEnvironment _env;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
        }

        public string Username { get; set; }


        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public bool IsDeleted { get; set; }
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [Required]
            [Display(Name = "New Name")]
            public string NewName { get; set; }
            [Required]
            [Display(Name = "New Surname")]
            public string NewSurname { get; set; }
            public string ImagePath { get; set; }
            [ValidImage(ImageSize = 2)]
            public IFormFile Image { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var ad = user.Name;
            var soyad = user.Surname;
            var imagePath = user.ImagePath;

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                NewName = ad,
                NewSurname = soyad,
                ImagePath = imagePath
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            user.Name = Input.NewName;
            user.Surname = Input.NewSurname;

            if (Input.IsDeleted || Input.Image != null)
            {
                DeleteFromStorage(user.ImagePath);
                user.ImagePath = AppendNewImageToStorage();
            }

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";


            return RedirectToPage();
        }

        private void DeleteFromStorage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath)) return;
            string deletePath = Path.Combine(_env.WebRootPath, "img", imagePath);
            System.IO.File.Delete(deletePath);
        }

        private string AppendNewImageToStorage()
        {
            string newImageName = null;
            if (Input.Image != null)
            {
                newImageName = Guid.NewGuid() + Input.Image.FileName;
                string imageDestinationPath = Path.Combine(_env.WebRootPath, "img", newImageName);
                using (var fs = new FileStream(imageDestinationPath, FileMode.Create))
                {
                    Input.Image.CopyTo(fs);
                }

            }
            return newImageName;
        }
    }
}
