using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartEmptyException : Exception
    {
        public string msg;
        public CartEmptyException()
        {

            msg = "Cart is empty";
        }
    }
}


