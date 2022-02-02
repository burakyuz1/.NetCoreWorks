using Microsoft.EntityFrameworkCore;
using SehirHavaDurumuKontrol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirHavaDurumuKontrol.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> option): base(option)
        {

        }



        public DbSet<Sehir> Sehirler{ get; set; }
        public DbSet<Bolge> Bolgeler{ get; set; }
    }
}
