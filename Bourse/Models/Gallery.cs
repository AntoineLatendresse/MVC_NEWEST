using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Gallery : SqlExpressUtilities.SqlExpressWrapper
    {

        public int ID { get; set; }
        public string Picture { get; set; }

        public Gallery(Object connexionString)
            : base(connexionString)
        {
            SQLTableName = "Gallery";
            
        }

        public Gallery()
            : base(VariablesGlobales.CONNECTION_STRING_MAINDB)
        {
            SQLTableName = "Gallery";
        }

        public override void GetValues()
        {
            ID = int.Parse(this["ID"]);
            Picture = this["Picture"];
        }

        public String GetGalleryURL()
        {
            String url;
            if (String.IsNullOrEmpty(Picture))
            {
                url = @"/ImagesGallery/anonymous.jpg";
            }
            else
            {
                url = @"/ImagesGallery/" + Picture;
            }

            return url;
        }

        public override void Insert()
        {
            InsertRecord(ID, Picture);
        }
        public override void Update()
        {
            UpdateRecord(ID, Picture);
        }
    }
}