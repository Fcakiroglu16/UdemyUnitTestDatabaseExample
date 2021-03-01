using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDatabaseExample.SQLITE.Models;

namespace UnitTestDatabaseExample.Test
{
    public class ProductControllerTest
    {
        protected DbContextOptions<AppDbContext> ContextOptions { get; set; }

        public void Seed()
        {
            using (var context = new AppDbContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Categories.Add(new Category { Id = 1, Name = "Kalemler" });
                context.Categories.Add(new Category { Id = 2, Name = "Dalemler" });

                context.SaveChanges();
            }
        }
    }
}