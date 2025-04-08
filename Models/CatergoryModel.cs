using System.ComponentModel.DataAnnotations;
namespace MyApp.Models
{
    public class Catergory
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public int DisplayOrder {get; set;}
    }
}