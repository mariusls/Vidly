using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 25)]
        public byte NumberInStock { get; set; }
    }
}