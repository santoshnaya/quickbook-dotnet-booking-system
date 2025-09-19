using System.ComponentModel.DataAnnotations;

namespace QuickBook.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(15, 480)] // 15 minutes to 8 hours
        public int Duration { get; set; } = 60; // Duration in minutes

        [Range(0, 10000)]
        public decimal Price { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}