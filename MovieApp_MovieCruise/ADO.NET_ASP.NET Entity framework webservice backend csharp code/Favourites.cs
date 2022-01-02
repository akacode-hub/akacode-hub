using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCrusier.Model
{
    public class Favourites
    {
        List<MovieItem> movieItemList;
        double total;

        public List<MovieItem> MovieItemList { get => movieItemList; set => movieItemList = value; }

        public double Total { get => total; set => total = value; }
        public Favourites() { }

        public Favourites(List<MovieItem> movieItemList, double total)
        {
            this.movieItemList = movieItemList;
            this.total = total;
        }

    }
}

