using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje classlarını bağlamak
    public class reCapProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-jr7sev1\sqlexpress;Database=reCapProject;Trusted_Connection=true");
        }

        //veritabanı bağlandı ve aşağıda hangi tablolara hangi classlar denk geliyor o belirlendi.
        //DbSet<Car> class olan Car ile dbdeki Cars bağlandı.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }


    }
}
