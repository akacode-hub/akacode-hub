using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        List<MenuItem> menuItemList;
        double total;

        public List<MenuItem> MenuItemList { get => menuItemList; set => menuItemList = value; }

        public double Total { get => total; set => total = value; }
        public Cart() { }

        public Cart(List<MenuItem> menuItemList, double total)
        {
            this.menuItemList = menuItemList;
            this.total = total;
        }

    }
}
