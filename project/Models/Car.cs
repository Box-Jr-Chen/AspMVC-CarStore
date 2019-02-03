using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int      Id        { get; set; }
        public string   Brand { get; set; }
        public string   Name      { get; set; }
        public decimal  Price     { get; set; }
        public string   ImageUrl  { get; set; }
        public string   Category  { get; set; }
        public int Year { get; set; }
        public int SoldNumber { get; set; }
    }
}