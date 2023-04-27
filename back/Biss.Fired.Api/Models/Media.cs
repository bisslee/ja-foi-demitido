using Microsoft.AspNetCore.Mvc.Formatters;
using System.ComponentModel.DataAnnotations;

namespace Biss.Fired.Api.Models
{
    public class Media
    {
        public int Id { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Fired Fired { get; set; }
        public string EmailWarning { get; set; }
        public string IP { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ValidadedAt { get; set; }
        public MediaType MediaType { get; set; }
    }

}
