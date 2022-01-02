using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Model;

namespace Com.Cognizant.MovieCrusier.Dao
{
    public class FavouritesEmptyException:Exception

    {
        public string msg;
        public FavouritesEmptyException()
        {

            msg = "Cart is empty";
        }
    }
}
