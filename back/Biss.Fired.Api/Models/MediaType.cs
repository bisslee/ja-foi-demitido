using System.ComponentModel.DataAnnotations;

namespace Biss.Fired.Api.Models
{
    public class MediaType
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }

}
