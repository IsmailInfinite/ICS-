using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF_CodeFirst_Ass1.Models
{
    public class Movies
    {
        [Key]

        public int MId { get; set; }
        public string Moviename { get; set; }
        public DateTime DateOfRelease { get; set; }

    }
}