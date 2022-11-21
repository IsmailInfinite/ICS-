using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF_CodeFirst_Ass1.Models
{
    public class MovieType : DbContext
    {
        public MovieType():base("name=Comedy")
        {

        }
        public DbSet<Movies> Movie { get; set; }
    }
}