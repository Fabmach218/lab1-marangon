using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab1_marangon.Models
{
    [Table("t_producto")]
    public class VideoGame
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}
        public string nombre {get; set;}
        public string categoria {get; set;}
        public decimal precio {get; set;}
        public decimal descuento {get; set;}
    }
}