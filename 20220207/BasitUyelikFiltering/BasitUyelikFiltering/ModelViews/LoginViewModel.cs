using System.ComponentModel.DataAnnotations;

namespace BasitUyelikFiltering.ModelViews
{
    public class LoginViewModel
    {
        //[EmailAddress(ErrorMessage = "Geçersiz bir e-mail adresi.")]
        [Required(ErrorMessage = "E-mail alanı zorunlu")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola Zorunludur.")]
        public string Parola { get; set; }
    }
}
