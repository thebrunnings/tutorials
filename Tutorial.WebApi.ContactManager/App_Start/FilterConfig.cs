﻿using System.Web;
using System.Web.Mvc;

namespace Tutorial.WebApi.ContactManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}