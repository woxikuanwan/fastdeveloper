using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcApplication2.Models
{
    public class articleEnf : DbContext
    {
        
        public DbSet<article> article { get; set; }
    }
}