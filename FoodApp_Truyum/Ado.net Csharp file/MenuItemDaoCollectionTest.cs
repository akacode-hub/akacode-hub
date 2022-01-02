using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        public void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection obj = new MenuItemDaoCollection();
            List<MenuItem> list = obj.GetMenuItemListAdmin();
            foreach (MenuItem m in list)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection obj = new MenuItemDaoCollection();
            List<MenuItem> list = obj.GetMenuItemListCustomer();
            foreach (MenuItem m in list)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void TestModifyMenuItem()
        {
            DateUtility d = new DateUtility();
            MenuItem m = new MenuItem(1, "Veg. Sandwich", (float)199.00, true, d.ConvertToShortDateString("02/11/2018"), "Main Course", true);
            MenuItemDaoCollection obj = new MenuItemDaoCollection();
            obj.ModifyMenuItem(m);
            MenuItem m1 = obj.GetMenuItem(1);
            Console.WriteLine("\n\tUpdated Data :- ");
            Console.WriteLine(m1.ToString());
            Console.WriteLine("\n\t");
        }
    }
}
