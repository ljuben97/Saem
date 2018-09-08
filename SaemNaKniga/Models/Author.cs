using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaemNaKniga.Models
{
    public class Author
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public int Gender { set; get; }
        [Required]
        [Display(Name="Image URL")]
        public string ImgUrl { set; get; }
        public string Biography { set; get; }
        public virtual ICollection<Book> Books { set; get; }

        public Author() {
            Books = new List<Book>();
        }
    }
}