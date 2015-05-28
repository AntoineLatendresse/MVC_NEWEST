using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class UsersModel : SqlExpressUtilities.SqlExpressWrapper
    {
        public long ID { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public String FullName { get; set; }

        public String EMail { get; set; }

        public String Telephone { get; set; }



        public UsersModel(Object connexionString)
            : base(connexionString)
        {
            SQLTableName = "USERS";
        }

        public UsersModel()
            : base("")
        {
        }
        public override void GetValues()
        {
            ID = long.Parse(this["ID"]);
            UserName = this["USERNAME"];
            Password = this["PASSWORD"];
            FullName = this["FULLNAME"];
            EMail = this["EMAIL"];
            Telephone = this["TELEPHONE"];
        }

        public override void Insert()
        {
            InsertRecord(UserName, Password, FullName, EMail, Telephone);
        }
        public override void Update()
        {
            UpdateRecord(ID, UserName, Password, FullName, EMail, Telephone);
        }

        public bool Exist(String userName)
        {
            bool exist = false;

            SelectByFieldName("USERNAME", userName);

            if (reader.HasRows)
            {
                Next();
                exist = true;
                EndQuerySQL();
            }
            return exist;
        }

        public bool Valid(String userName, String Password)
        {
            bool valid = false;
            SelectByFieldName("USERNAME", userName);
            valid = (this.Password == Password);
            return valid;
        }
    }
}