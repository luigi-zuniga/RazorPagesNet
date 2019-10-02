using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models
{
    /// <summary>
    /// Movie
    /// </summary>
    /// <param>
    /// DataType : se utiliza para asignar DataTypeAttribute,
    /// es a una sola regla de validación del lado del cliente.
    /// </param>
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime RealeaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

