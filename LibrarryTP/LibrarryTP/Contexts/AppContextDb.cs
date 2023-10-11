using LibrarryTP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarryTP.Contexts
{
    internal class AppContextDb : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public string Path { get; set; } = "Data Source = homebank.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Path);
        }
    }
}
