using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RabbitMQWeb.Watermark.Models
{
    public class Product
    {
    
        public int Id { get; set; }
      
        public string Name { get; set; }
        
        public decimal Price { get; set; }
       
        public int Stock { get; set; }
        
        public string ImageName { get; set; }
    }
}
