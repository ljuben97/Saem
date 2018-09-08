using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SaemNaKniga.Models;

namespace SaemNaKniga.Models.Publish_House_Models
{
    public class PublisHouseBuyBook
    {
        public PublishHouse publishHouse { get; set; }
        public BookExtended bookExtended { get; set; }

        [Required(ErrorMessage ="You must enter the number of books you would like to buy")]
        [Display(Name ="Enter the number of books you would like to buy")]
        public int UnitsBuy { get; set; }

        public int BookId { get; set; }

        public int PublishHouseId { get; set; }
    }
}