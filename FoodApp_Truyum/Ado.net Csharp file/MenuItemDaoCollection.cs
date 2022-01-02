using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using Com.Cognizant.Truyum.Dao;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        List<MenuItem> menuItemList;

        public MenuItemDaoCollection()
        {
            if (menuItemList == null)
            {
                DateUtility d = new DateUtility();
                menuItemList = new List<MenuItem>();
                menuItemList.Add(new MenuItem(1,"Sandwich", (float)99.00, true, d.ConvertToShortDateString("15/03/2017"), "Main Course", true));
                menuItemList.Add(new MenuItem(2,"Burger", (float)129.00, true, d.ConvertToShortDateString("23/12/2017"), "Main Course", false));
                menuItemList.Add(new MenuItem(3,"Pizza", (float)149.00, true, d.ConvertToShortDateString("21/08/2018"), "Main Course", false));
                menuItemList.Add(new MenuItem(4,"French Fries", (float)57.00, false, d.ConvertToShortDateString("02/07/2017"), "Starters", true));
                menuItemList.Add(new MenuItem(5,"Chocolate Brownie", (float)32.00, true, d.ConvertToShortDateString("02/11/2022"), "Dessert", true));
            }
        }
        public MenuItem GetMenuItem(long menuItemId)
        {
            for (int i = 0; i < menuItemList.Count; i++)
            {
                if (menuItemList[i].Id == menuItemId)
                {
                    return menuItemList[i];
                }
            }
            return null;
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;

        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            DateUtility d = new DateUtility();
            for (int i = menuItemList.Count-1; i >= 0; i--)
            {
                if (menuItemList[i].DateOfLaunch > DateTime.Now)
                    menuItemList.RemoveAt(i);
                else
                    if (menuItemList[i].Active != true)
                    menuItemList.RemoveAt(i);
            }
            return menuItemList;
        }



        public void ModifyMenuItem(MenuItem menuItem)
        {
            for (int i = 0; i < menuItemList.Count; i++)
            {
                if (menuItemList[i].Equals(menuItem))
                {
                    menuItemList[i] = menuItem;
                    break;
                }
            }

        }
    }
}
