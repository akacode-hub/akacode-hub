using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCrusier.Model
{
    public class MovieItem

    {
        long id;
        string title;
        float boxoffice;
        Boolean active;
        DateTime dateOfLaunch;
        string genre;
        Boolean hasteaser;

        public MovieItem() { }

        public MovieItem(long id, string title, float boxoffice, Boolean active, DateTime dateOfLaunch, string genre, Boolean hasteaser)
        {
            this.id = id;
            this.title = title;
            this.boxoffice = boxoffice;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.genre = genre;
            this.hasteaser = hasteaser;
        }

        public string Title

        {

            get { return title; }

            set { title = value; }

        }
        public string Genre

        {

            get { return genre; }

            set { genre = value; }

        }
        public float Boxoffice

        {

            get { return boxoffice; }

            set { boxoffice = value; }

        }
        public Boolean Active

        {

            get { return active; }

            set { active = value; }

        }
        public Boolean Hasteaser

        {

            get { return hasteaser; }

            set { hasteaser = value; }

        }
        public DateTime DateOfLunch

        {

            get { return dateOfLaunch; }

            set { dateOfLaunch = value; }

        }
        public long Id { get => id; set => id = value; }


        public override string ToString()
        {
            string s = string.Format("{0:C}", boxoffice);
            string str = string.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,20}{6,10}", id, title, s, active, dateOfLaunch, genre, hasteaser);
            return str;
        }


        public override bool Equals(object obj)
        {
            MovieItem temp = (MovieItem)obj;
            if (temp.id == id)
            {
                return true;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


}

