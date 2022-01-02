using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Utility;

namespace Com.Cognizant.MovieCrusier.Dao
{
    public interface IMovieDao
    {


        List<MovieItem> GetMovieItemListAdmin();
        List<MovieItem> GetMovieItemListCustomer();
        void ModifyMovieItem(MovieItem menuItem);
        MovieItem GetMovieItem(long movieItemId);

    }
}
