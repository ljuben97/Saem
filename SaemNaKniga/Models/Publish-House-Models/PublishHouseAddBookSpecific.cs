using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SaemNaKniga.Models;

namespace SaemNaKniga.Models.Publish_House_Models
{
    public class PublishHouseAddBookSpecific
    {
        public PublishHouse publishHouse { get; set; }
        public List<Book> books { get; set; }


        [Required]
        [Display(Name ="Select a Book")]
        public int BookId { get; set; }

        public int PublishHouseId { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [Display(Name ="Units")]
        public int InStock { get; set; }
    }
}