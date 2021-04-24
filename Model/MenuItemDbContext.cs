using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Model
{
    public class MenuItemDbContext : DbContext
    {
        public MenuItemDbContext(DbContextOptions<MenuItemDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                //Id = 1,
                Name = "Pizza",
                FreeDelivery = true,
                Price = 350,
                DateOfLaunch = new DateTime(2021, 04, 25),
                Active = true
            }, new MenuItem
            {
                //Id = 2,
                Name = "Burger",
                FreeDelivery = true,
                Price = 350,
                DateOfLaunch = new DateTime(2021, 04, 29),
                Active = true
            });
        }*/
    }
}
