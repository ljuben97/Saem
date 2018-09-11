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


        [Required (ErrorMessage ="Мора да имате избрано книга")]
        [Display(Name ="Изберете книга")]
        public int BookId { get; set; }

        public int PublishHouseId { get; set; }

        [Required (ErrorMessage ="Мора да внесите цена во полето")]
        [Display(Name ="Цена")]
        public int Price { get; set; }

        [Required (ErrorMessage ="Мора да имате внесено број на книги")]
        [Display(Name ="Број на книги")]
        public int InStock { get; set; }
    }
}