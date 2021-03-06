﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.WebDashboardRazor.Models
{
    public enum SelectedMenu
    {
        Reports_Product,
        Reports_Country,
        Data_Sales,
        Data_Product,
        Data_Customer,
        Data_SalesByProduct,
        Data_SalesByCountry
    }

    public static class ViewDataHelpers
    {
        private static string selectedMenuKey = "selectedMenu";

        public static void SetSelectedMenu(this ViewDataDictionary viewData, SelectedMenu selectedMenu)
        {
            viewData[selectedMenuKey] = selectedMenu;
        }

        public static SelectedMenu GetSelectedMenu(this ViewDataDictionary viewData)
        {
            return (SelectedMenu)viewData[selectedMenuKey];
        }
    }
}
