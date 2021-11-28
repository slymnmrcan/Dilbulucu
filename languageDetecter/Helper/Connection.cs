using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace languageDetecter.Helper
{
    public class Connection
    {
        public static string ConString()
        {
            return ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        }
    }
}