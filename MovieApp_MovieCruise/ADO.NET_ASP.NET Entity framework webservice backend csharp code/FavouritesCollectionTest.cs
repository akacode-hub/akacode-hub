using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Utility;

namespace Com.Cognizant.MovieCruiser.Dao
{
    public class FavoritesDaoCollectionTest
    {
        FavoritesDaoCollection FavoritesDao;
        public FavoritesDaoCollectionTest()
        {
            FavoritesDao = new FavoritesDaoCollection();
        }

        public void TestAddFavoriteItem()
        {
            DateUtility d = new DateUtility();
            FavoritesDao.AddFavoritesItem(102,1);
            Favourites c = FavoritesDao.GetAllFavoritesItems(102);
           
            Console.WriteLine("\n\t");
            int a1 = 0;
            foreach (MovieItem m in c.MovieItemList)
            {
                Console.WriteLine(m.ToString());
                a1++;
            }
            Console.WriteLine("\n\t\t No Of Favourites : "+a1);
            //Console.WriteLine("\n\t");
        }

        public void TestRemoveFavoriteItem()
        {
            FavoritesDao.RemoveFavoritesItem(102, 3);
            Favourites c = FavoritesDao.GetAllFavoritesItems(102);
            
            Console.WriteLine("\n\t");
            int a2 = 0;
            foreach (MovieItem m in c.MovieItemList)
            {
                Console.WriteLine(m.ToString());
                a2++;
            }
            Console.WriteLine("\n\t\t No Of Favourites : " + a2);
            Console.WriteLine("\n\t");
        }
    }
}
