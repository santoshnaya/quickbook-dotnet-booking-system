using Microsoft.EntityFrameworkCore;
using QuickBook.Data;
using QuickBook.Models;
using QuickBook.ViewModels;

namespace QuickBook.Services
{
    public class ServiceManagementService : IServiceManagementService
    {
        private readonly ApplicationDbContext _context;

        public ServiceManagementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Service>> GetAllServicesAsync()
        {
            return await _context.Services
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<Service?> GetServiceByIdAsync(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task<bool> CreateServiceAsync(ServiceViewModel model)
        {
            try
            {
                var service = new Service
                {
                    Name = model.Name,
                    Description = model.Description,
                    Duration = model.Duration,
                    Price = model.Price,
                    CreatedAt = DateTime.UtcNow
                };

                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateServiceAsync(ServiceViewModel model)
        {
            try
            {
                var service = await _context.Services.FindAsync(model.Id);
                if (service == null) return false;

                service.Name = model.Name;
                service.Description = model.Description;
                service.Duration = model.Duration;
                service.Price = model.Price;

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteServiceAsync(int id)
        {
            try
            {
                var service = await _context.Services.FindAsync(id);
                if (service == null) return false;

                // Check if service has bookings
                var hasBookings = await _context.Bookings.AnyAsync(b => b.ServiceId == id);
                if (hasBookings) return false; // Cannot delete service with existing bookings

                _context.Services.Remove(service);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}