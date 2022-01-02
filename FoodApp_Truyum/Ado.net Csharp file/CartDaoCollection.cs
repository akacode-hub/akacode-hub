using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollection : ICartDao
    {
        Dictionary<long, Cart> userCarts;

        public CartDaoCollection()
        {
            if (userCarts == null)
            {
                userCarts = new Dictionary<long, Cart>();
                List<MenuItem> lst;
                DateUtility d = new DateUtility();
                lst = new List<MenuItem>();
                lst.Add(new MenuItem(1, "Sandwich", (float)99.00, true, d.ConvertToShortDateString("15/03/2017"), "Main Course", true));
                lst.Add(new MenuItem(2, "Burger", (float)129.00, true, d.ConvertToShortDateString("23/12/2017"), "Main Course", false));
                Cart c = new Cart(lst, 0);
                userCarts.Add(101, c);
                lst = new List<MenuItem>();
                lst.Add(new MenuItem(3, "Pizza", (float)149.00, true, d.ConvertToShortDateString("21/08/2018"), "Main Course", false));
                lst.Add(new MenuItem(4, "French Fries", (float)57.00, false, d.ConvertToShortDateString("02/07/2017"), "Starters", true));
                lst.Add(new MenuItem(5, "Chocolate Brownie", (float)32.00, true, d.ConvertToShortDateString("02/11/2022"), "Dessert", true));
                userCarts.Add(102, new Cart(lst, 0));
            }
        }
        public void AddCartItem(long userId, long menuItemId)
        {
            //throw new NotImplementedException();
            MenuItemDaoCollection MenuItemDao = new MenuItemDaoCollection();
            MenuItem newmenu = MenuItemDao.GetMenuItem(menuItemId);
            int f = 0;
            foreach (var u in userCarts)
            {
                if (u.Key == userId)
                {
                    userCarts[userId].MenuItemList.Add(newmenu);
                    f = 1;
                    break;
                }
            }

            if (f == 0)
            {
                List<MenuItem> lst = new List<MenuItem>();
                lst.Add(newmenu);
                userCarts.Add(userId, new Cart(lst, 0));
            }
        }

        public  Cart GetAllCartItems(long userId)
        {
            //throw new NotImplementedException();
            double sum = 0;
            if (userCarts.Count == 0)
            {
                throw new CartEmptyException();
            }
            else
            {
                foreach (var d in userCarts)
                {
                    if (d.Key == userId)
                    {
                        foreach (var n in d.Value.MenuItemList)
                        {
                            sum = sum + n.Price;
                        }
                        d.Value.Total = sum;
                        return d.Value;
                    }
                }
            }
            return null;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            //throw new NotImplementedException();
            foreach (var d in userCarts)
            {
                if (d.Key == userId)
                {
                    List<MenuItem> lst = d.Value.MenuItemList;
                    for (int i = 0; i < d.Value.MenuItemList.Count; i++)
                    {
                        if (d.Value.MenuItemList[i].Id == menuItemId)

                        {
                            d.Value.MenuItemList.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        void ICartDao.GetAllCartItems(long userId)
        {
            //throw new NotImplementedException();
            
        }
    }
}
