using System.ComponentModel.DataAnnotations;
using QuickBook.Models;

namespace QuickBook.ViewModels
{
    public class BookingViewModel
    {
        [Required(ErrorMessage = "Please select a service")]
        [Display(Name = "Service")]
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Please select a date")]
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; } = DateTime.Today.AddDays(1);

        [Required(ErrorMessage = "Please select a time")]
        [DataType(DataType.Time)]
        [Display(Name = "Booking Time")]
        public TimeSpan BookingTime { get; set; }

        [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
        [Display(Name = "Additional Notes")]
        public string Notes { get; set; } = string.Empty;

        // For dropdown
        public List<Service> AvailableServices { get; set; } = new List<Service>();
    }
}