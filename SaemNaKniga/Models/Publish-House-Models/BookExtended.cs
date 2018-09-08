using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using SaemNaKniga.Models;

namespace SaemNaKniga.Models.Publish_House_Models
{
    [NotMapped]
    public class BookExtended : Book
    {
        [Required]
        public int Price { get; set; }
        [Required]
        public int Units { get; set; }
    }
}