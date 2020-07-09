using System;
using System.ComponentModel.DataAnnotations;

namespace bookapi.Models
{
    public class Book
    {
        public Book(string title, string author, bool available)
        {
            this.Title = title;
            this.Author = author;
            this.Available = available;
            this.Id = Guid.NewGuid().ToString();

        }

        public Book(){
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public bool Available { get; set; }

    }
}