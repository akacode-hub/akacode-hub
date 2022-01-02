using System;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using Com.Cognizant.Truyum.Dao;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollectionTest
    {
        CartDaoCollection CartDao;
        public CartDaoCollectionTest()
        {
            CartDao = new CartDaoCollection();
        }

        public void TestAddCartItem()
        {
            DateUtility d = new DateUtility();
            CartDao.AddCartItem(101, 3);
            Cart c = CartDao.GetAllCartItems(101);
            foreach (MenuItem m in c.MenuItemList)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine("\n\t\t Total Price " + string.Format("{0:C}", c.Total));
            Console.WriteLine("\n\t");
        }

        public void TestRemoveCartItem()
        {
            CartDao.RemoveCartItem(101, 3);
            Cart c = CartDao.GetAllCartItems(101);
            foreach (MenuItem m in c.MenuItemList)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine("\n\t\t Total Price " + string.Format("{0:C}", c.Total));
            Console.WriteLine("\n\t");
        }

    }
}
