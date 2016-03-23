using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class User
    {
        private int userid;

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}