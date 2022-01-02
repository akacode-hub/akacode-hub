using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCrusier.Dao;

namespace Finalcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDaoCollectionTest obj = new MovieDaoCollectionTest();
            Console.WriteLine("\n\t Admin Data :- ");
            Console.WriteLine("\n\t");
            obj.TestGetMovieItemListAdmin();
            Console.WriteLine("\n\t Customer Data :- ");
            Console.WriteLine("\n\t");
            obj.TestGetMovieItemListCustomer();
            Console.WriteLine("\n\t Modified Data :- ");
            obj.TestModifyMovieItem();

            try
            {
                FavoritesDaoCollectionTest ob = new FavoritesDaoCollectionTest();
                Console.WriteLine("\n\t Added Data :- ");
                ob.TestAddFavoriteItem();
                Console.WriteLine("\n\t Removed Data :- ");
                ob.TestRemoveFavoriteItem();
            }
            catch (FavouritesEmptyException ex)
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
   