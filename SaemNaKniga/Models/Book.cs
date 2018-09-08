using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaemNaKniga.Models
{
    public class Book
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [Range (0,2018, ErrorMessage = "The year must be a positive number")]
        public int Year { set; get; }
        [Required]
        [Display(Name = "Image URL")]
        public string ImgUrl { set; get; }
        public string Description { set; get; }
        public virtual Author Author { set; get; }
        public virtual ICollection<PublishHouse> PublishHouses { set; get; }

        public Book() {
            PublishHouses = new List<PublishHouse>();
        }
    }
}