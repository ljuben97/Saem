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
    public class PublishHouseIncreaseBooks
    {
        public PublishHouse publishHouse { get; set; }
        public List<Book> books { get; set; }

        [Required]
        [Display(Name ="Select a Book")]
        public int BookId { get; set; }

        [Required(ErrorMessage ="You must enter the number of units you would like to buy")]
        [Display(Name ="Type the number of books you would like to increase")]
        public int Units { get; set; }

        public int PublishHouseId { get; set; }

        public PublishHouseIncreaseBooks()
        {
            books = new List<Book>();
        }

        public Book getById(int id)
        {
            foreach (Book book in books)
                if (book.Id == id)
                    return book;
            return null;
        }
    }
}