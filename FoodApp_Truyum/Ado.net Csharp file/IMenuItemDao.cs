﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    public interface IMenuItemDao
    {
        
        
            List<MenuItem> GetMenuItemListAdmin();
            List<MenuItem> GetMenuItemListCustomer();
            void ModifyMenuItem(MenuItem menuItem);
            MenuItem GetMenuItem(long menuItemId);

        }
    }
