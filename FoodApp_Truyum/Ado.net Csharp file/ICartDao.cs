using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    public interface ICartDao
    {
        void AddCartItem(long userId, long menuItemId);
        void GetAllCartItems(long userId);
        void RemoveCartItem(long userId, long productId);
    }
}
