//using _19._08._2019.Content.Pictures.Genre;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace _19._08._2019
{
    public class Genre
    {
        [Key]
        public int ID { get; set; } 
        public string Name { get; set; }
        public string PicturePath { get; set; }
    }
}