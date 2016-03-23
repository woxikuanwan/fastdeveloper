using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    
    public class address
    {
        private int addressid;

        public int Addressid
        {
            get { return addressid; }
            set { addressid = value; }
        }



        private string addressname;

        public string Addressname
        {
            get { return addressname; }
            set { addressname = value; }
        }

        
    }
}