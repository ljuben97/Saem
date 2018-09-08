using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaemNaKniga.Models
{
    public class PublishHouse
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [Display(Name="Image URL")]
        public string ImgUrl { set; get; }
        public string Description { set; get; }
        public virtual ICollection<Book> Books { set; get; }

        public PublishHouse() {
            Books = new List<Book>();
        }
    }
}