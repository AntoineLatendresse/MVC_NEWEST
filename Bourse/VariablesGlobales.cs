using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Class
{
    public static class VariablesGlobales
    {
        public static string CONNECTION_STRING_MAINDB = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|datadirectory|MainDB.mdf';Integrated Security=True;";
        public static string CONNECTION_STRING_Gallery = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|datadirectory|Gallery.mdf';Integrated Security=True;";
        public static string TABLE_USERS = "USERS";
        public static string TABLE_GALLERY = "Gallery";
    }
}