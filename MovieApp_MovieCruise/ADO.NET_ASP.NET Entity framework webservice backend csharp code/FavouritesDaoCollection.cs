using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Dao;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Utility;

namespace Com.Cognizant.MovieCruiser.Dao
{
    public class FavoritesDaoCollection : IFavouritesDao
    {
        Dictionary<long, Favourites> userFavorites;

        public FavoritesDaoCollection()
        {
            if (userFavorites == null)
            {
                userFavorites = new Dictionary<long, Favourites>();
                List<MovieItem> lst;
                DateUtility d = new DateUtility();
                lst = new List<MovieItem>();
                lst.Add(new MovieItem(1, "Avatar", (float)2787965087, true, d.ConvertToShortDateString("15/03/2017"), "Science Fiction", true));
                lst.Add(new MovieItem(2, "The Avengers", (float)1518812988, true, d.ConvertToShortDateString("23/12/2017"), "Superhero", false));
                lst.Add(new MovieItem(4, "Jurassic World", (float)1671713208, false, d.ConvertToShortDateString("02/07/2017"), "Science Fiction", true));

                Favourites c = new Favourites(lst, 0);
                userFavorites.Add(101, c);
                lst = new List<MovieItem>();
                lst.Add(new MovieItem(3, "Titanic", (float)2187463944, true, d.ConvertToShortDateString("21/08/2018"), "Romance", false));
               
                lst.Add(new MovieItem(5, "Avengers", (long)2750765348, true, d.ConvertToShortDateString("02/11/2022"), "Superhero", true));
                userFavorites.Add(102, new Favourites(lst, 0));
            }
        }
        public void AddFavoritesItem(long userId, long movieItemId)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            MovieDaoCollection MenuItemDao = new MovieDaoCollection();
            MovieItem newmovie = MenuItemDao.GetMovieItem(movieItemId);
            int f = 0;
            foreach (var u in userFavorites)
            {
                if (u.Key == userId)
                {
                    userFavorites[userId].MovieItemList.Add(newmovie);
                    f = 1;
                    break;
                }
            }

            if (f == 0)
            {
                List<MovieItem> lst = new List<MovieItem>();
                lst.Add(newmovie);
                userFavorites.Add(userId, new Favourites(lst, 0));
            }
        }

        public void AddFavouriteItem(long userId, long MovieItemId)
        {
            throw new NotImplementedException();
        }

        public Favourites GetAllFavoritesItems(long userId)
        {
            //throw new NotImplementedException();
            double sum = 0;
            if (userFavorites.Count == 0)
            {
                throw new FavouritesEmptyException();
            }
            else
            {
                foreach (var d in userFavorites)
                {
                    if (d.Key == userId)
                    {
                        foreach (var n in d.Value.MovieItemList)
                        {
                            sum = sum + n.Boxoffice;
                        }
                        d.Value.Total = sum;
                        return d.Value;
                    }
                }
            }
            return null;
        }

        public void GetAllFavouriteItems(long userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveFavoritesItem(long userId, long movieItemId)
        {
            //throw new NotImplementedException();
            foreach (var d in userFavorites)
            {
                if (d.Key == userId)
                {
                    List<MovieItem> lst = d.Value.MovieItemList;
                    for (int i = 0; i < d.Value.MovieItemList.Count; i++)
                    {
                        if (d.Value.MovieItemList[i].Id == movieItemId)

                        {
                            d.Value.MovieItemList.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        public void RemoveFavouriteItem(long userId, long MovieItemId)
        {
            throw new NotImplementedException();
        }
    }
}
