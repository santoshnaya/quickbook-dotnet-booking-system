using System.ComponentModel.DataAnnotations;

namespace QuickBook.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Service name is required")]
        [StringLength(200, ErrorMessage = "Service name cannot exceed 200 characters")]
        [Display(Name = "Service Name")]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Duration is required")]
        [Range(15, 480, ErrorMessage = "Duration must be between 15 and 480 minutes")]
        [Display(Name = "Duration (minutes)")]
        public int Duration { get; set; } = 60;

        [Required(ErrorMessage = "Price is required")]
        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10000")]
        [Display(Name = "Price ($)")]
        public decimal Price { get; set; } = 0;
    }
}