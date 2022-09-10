using Lesson.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Data
{
    public class Database
    {


        public Database()
        {

            var sahin = new User { Id = 1, FullName = "Sahin", Login = "Sahin", Password = "Sahin", IsAdmin = true };
            var product = new Product { Id = 1, Name = "Bal", User = sahin };
            Users = new DbSet<User>
            {
                sahin
            };
            Sales = new DbSet<Sale>();
            Products = new DbSet<Product>
            {
                product
            };
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
