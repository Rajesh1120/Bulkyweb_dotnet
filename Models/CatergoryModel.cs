using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Cors;
namespace MyApp.Models
{
    public class Catergory
    {
        [Key]
        public int Id {get; set;}
        
        [Required]
        [MaxLength(30)]
        
        [DisplayName("Catergory Name")]
        public string Name { get; set;}
        [Required]
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage="The field Display Order must be between 1 - 100")]
        public int DisplayOrder {get; set;}
    }
}