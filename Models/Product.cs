using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        public int Id { get; set; } // Llave primaria
        public string name { get; set; }
        [Column (TypeName ="decimal(6,2")]
        public decimal Price { get; set; }
        public int Stock { get; set; } //  Llave foranea  
        public Category Category { get; set; } // Propiedad de navegacion 
    }
}
