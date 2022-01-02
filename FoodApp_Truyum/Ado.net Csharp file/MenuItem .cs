using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        long id;
        string name;
        float price;
        Boolean active;
        DateTime dateOfLaunch;
        string category;
        Boolean freeDelivery;

        public MenuItem() { }

        public MenuItem(long id, string name, float price, Boolean active, DateTime dateOfLaunch, string category, Boolean freeDelivery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.category = category;
            this.freeDelivery = freeDelivery;
        }

        public long Id { get { return id; } set { id = value; } }
        public string Name

        {

            get { return name; }

            set { name = value; }

        }
        public float Price

        {

            get { return price; }

            set { price = value; }

        }
        public Boolean Active

        {

            get { return active; }

            set { active = value; }

        }
        public DateTime DateOfLaunch

        {

            get { return dateOfLaunch; }

            set { dateOfLaunch = value; }

        }
        public string Category

        {

            get { return category; }

            set { category = value; }

        }
        public Boolean FreeDelivery

        {

            get { return freeDelivery; }

            set { freeDelivery = value; }

        }
       
       


        public override string ToString()
        {
            string s = string.Format("{0:C}", price);
            string str = string.Format("{0,-10}{1,-20}{2,-10}{3,-10}{4,-20}{5,20}{6,10}", id, name, s, active, dateOfLaunch, category, freeDelivery);
            return str;
        }


        public override bool Equals(object obj)
        {
            MenuItem temp = (MenuItem)obj;
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

