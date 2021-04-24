using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Model.Repository
{
    public class DataRepository : IDataRepository<MenuItem>
    {
        readonly MenuItemDbContext _Context;
        public DataRepository(MenuItemDbContext context)
        {
            _Context = context;
            
        }
        public IEnumerable<MenuItem> GetAll()
        {
            MenuItem m1 = new MenuItem()
            {
                Name = "HP Laptop",
                FreeDelivery = false,
                Price = 52000,
                DateOfLaunch = new DateTime(2021, 04, 25),
                Active = true
            };
            MenuItem m2 = new MenuItem()
            {
                //Id = 2,
                Name = "Apple",
                FreeDelivery = false,
                Price = 80000,
                DateOfLaunch = new DateTime(2021, 04, 29),
                Active = true
            };
            MenuItem m3 = new MenuItem()
            {
                //Id = 2,
                Name = "Dell",
                FreeDelivery = false,
                Price = 35000,
                DateOfLaunch = new DateTime(2021, 02, 09),
                Active = true
            };
            MenuItem m4 = new MenuItem()
            {
                //Id = 2,
                Name = "Lenovo",
                FreeDelivery = true,
                Price = 45000,
                DateOfLaunch = new DateTime(2021, 09, 19),
                Active = true
            };
            MenuItem m5 = new MenuItem()
            {
                //Id = 2,
                Name = "Samsung Galaxy f62",
                FreeDelivery = true,
                Price = 46000,
                DateOfLaunch = new DateTime(2021, 09, 19),
                Active = true
            };
            MenuItem m6 = new MenuItem()
            {
                //Id = 2,
                Name = "Samsung Galaxy a50",
                FreeDelivery = false,
                Price = 22000,
                DateOfLaunch = new DateTime(2020, 09, 19),
                Active = true
            };
            if (_Context.MenuItems.Count() == 0)
            {
                _Context.Add(m1);
                _Context.Add(m2);
                _Context.Add(m3);
                _Context.Add(m4);
                _Context.Add(m5);
                _Context.Add(m6);
                _Context.SaveChanges();
            }
            return _Context.MenuItems.ToList();
        }
        public string Get(long id)
        {
            var menuitem = _Context.MenuItems
                  .FirstOrDefault(e => e.Id == id);
            return menuitem.Name;
        }
    }
}
