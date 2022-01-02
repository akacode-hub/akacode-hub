using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Utility;


namespace Com.Cognizant.MovieCruiser.Dao
{
    public class MovieDaoCollectionTest
    {
        public void TestGetMovieItemListAdmin()
        {
            MovieDaoCollection obj = new MovieDaoCollection();
            List<MovieItem> list = obj.GetMovieItemListAdmin();
            foreach (MovieItem m in list)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void TestGetMovieItemListCustomer()
        {
            MovieDaoCollection obj = new MovieDaoCollection();
            List<MovieItem> list = obj.GetMovieItemListCustomer();
            foreach (MovieItem m in list)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void TestModifyMovieItem()
        {
            DateUtility d = new DateUtility();
            MovieItem m = new MovieItem(1, "Avengers", (float)2750765000.00, true, d.ConvertToShortDateString("02/11/2022"), "Superhero", true);
            MovieDaoCollection obj = new MovieDaoCollection();
            obj.ModifyMovieItem(m);
            MovieItem m1 = obj.GetMovieItem(1);
            Console.WriteLine("\n\t");
            Console.WriteLine(m1.ToString());
            Console.WriteLine("\n\t");
        }
    }
}
