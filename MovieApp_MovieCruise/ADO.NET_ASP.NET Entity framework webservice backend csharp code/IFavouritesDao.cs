using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCrusier.Model;
using Com.Cognizant.MovieCrusier.Dao;
using Com.Cognizant.MovieCrusier.Utility;

namespace Com.Cognizant.MovieCrusier.Dao
{
    public interface IFavouritesDao
    {
      
            void AddFavouriteItem(long userId, long MovieItemId);
            void GetAllFavouriteItems(long userId);
            void RemoveFavouriteItem(long userId, long MovieItemId);
        }
    }

