using QuickBook.Models;
using QuickBook.ViewModels;

namespace QuickBook.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetUserBookingsAsync(string userId);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking?> GetBookingByIdAsync(int id);
        Task<bool> CreateBookingAsync(BookingViewModel model, string userId);
        Task<bool> UpdateBookingStatusAsync(int id, BookingStatus status);
        Task<bool> DeleteBookingAsync(int id);
        Task<IEnumerable<Service>> GetAllServicesAsync();
    }
}