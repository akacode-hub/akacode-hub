using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using Com.Cognizant.Truyum.Dao;



namespace  testapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItemDaoCollectionTest obj = new MenuItemDaoCollectionTest();
            Console.WriteLine("\n\t Admin Data :- ");
            obj.TestGetMenuItemListAdmin();
            Console.WriteLine("\n\t Customer Data :- ");
            obj.TestGetMenuItemListCustomer();
            Console.WriteLine("\n\t Updated Data :- ");
             obj.TestModifyMenuItem();
            try
            {
               CartDaoCollectionTest ob = new CartDaoCollectionTest();
                Console.WriteLine("\n\t Added Data :- ");
                ob.TestAddCartItem();
                Console.WriteLine("\n\t Removed Data :- ");
                ob.TestRemoveCartItem();
            }
            catch (CartEmptyException ex)
            {
               Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
