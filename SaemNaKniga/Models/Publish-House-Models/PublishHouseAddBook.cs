using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SaemNaKniga.Models;

namespace SaemNaKniga.Models.Publish_House_Models
{
    public class PublishHouseAddBook
    {
        public List<PublishHouse> publishHouses { get; set; }
        public List<Book> books { get; set; }


        [Required]
        public int Price { get; set; }

        [Required]
        [Display(Name ="Units")]
        public int InStock { get; set; }

        [Required(ErrorMessage ="You must select a Publish House")]
        [Display(Name ="Select a Publish House")]
        public int PublishHouseId { get; set; }

        [Required (ErrorMessage ="You must select a Book")]
        [Display(Name ="Select a Book")]
        public int BookId { get; set; }
    }
}