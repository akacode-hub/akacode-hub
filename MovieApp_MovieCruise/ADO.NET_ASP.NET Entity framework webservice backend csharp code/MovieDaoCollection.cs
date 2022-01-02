using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Utility;
using Com.Cognizant.MovieCrusier.Dao;

namespace Com.Cognizant.MovieCruiser.Dao
{
    public class MovieDaoCollection : IMovieDao
    {
        List<MovieItem> movieItemList;

        public MovieDaoCollection()
        {
            if (movieItemList == null)
            {
                DateUtility d = new DateUtility();
                movieItemList = new List<MovieItem>();
                movieItemList.Add(new MovieItem(1, "Avatar", (float)2787965087, true, d.ConvertToShortDateString("15/03/2017"), "Science Fiction", true));
                movieItemList.Add(new MovieItem(2, "The Avengers", (float)1518812988, true, d.ConvertToShortDateString("23/12/2017"), "Superhero", false));
                movieItemList.Add(new MovieItem(3, "Titanic", (float)2187463944, true, d.ConvertToShortDateString("21/08/2018"), "Romance", false));
                movieItemList.Add(new MovieItem(4, "Jurassic World", (float)1671713208, false, d.ConvertToShortDateString("02/07/2017"), "Science Fiction", true));
                movieItemList.Add(new MovieItem(5, "Avengers: End Game", (long)2750765348, true, d.ConvertToShortDateString("02/11/2022"), "Superhero", true));
            }
        }

        public MovieItem GetMovieItem(long movieItemId)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < movieItemList.Count; i++)
            {
                if (movieItemList[i].Id == movieItemId)
                {
                    return movieItemList[i];
                }
            }
            return null;
        }

        public List<MovieItem> GetMovieItemListAdmin()
        {
            //throw new NotImplementedException();
            return movieItemList;
        }

        public List<MovieItem> GetMovieItemListCustomer()
        {
            //throw new NotImplementedException();
            DateUtility d = new DateUtility();
            for (int i = movieItemList.Count - 1; i >= 0; i--)
            {
                if (movieItemList[i].DateOfLunch > DateTime.Now)
                    movieItemList.RemoveAt(i);
                else
                    if (movieItemList[i].Active != true)
                    movieItemList.RemoveAt(i);
            }
            return movieItemList;
        }

        public void ModifyMovieItem(MovieItem movieItem)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < movieItemList.Count; i++)
            {
                if (movieItemList[i].Equals(movieItem))
                {
                    movieItemList[i] = movieItem;
                    break;
                }
            }
        }
    }
}
