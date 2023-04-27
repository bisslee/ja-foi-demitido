using System.ComponentModel.DataAnnotations;

namespace Biss.Fired.Api.Models
{
    public class Fired
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool WasFired { get; set; }
        public string IP { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ValidadedAt { get; set; }
        public DateTime? FiredAt { get; set; }
    }

}
