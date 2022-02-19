using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApi.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                
                new ToDoItem() { Id = 1 , Name = "Shopping"},
                new ToDoItem() { Id = 2 , Name = "Homework"},
                new ToDoItem() { Id = 3 , Name = "Coding"},
                new ToDoItem() { Id = 4 , Name = "Nothing"}
                
                );
        }
    }
}
