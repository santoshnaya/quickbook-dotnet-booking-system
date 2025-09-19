using QuickBook.Models;
using QuickBook.ViewModels;

namespace QuickBook.Services
{
    public interface IServiceManagementService
    {
        Task<IEnumerable<Service>> GetAllServicesAsync();
        Task<Service?> GetServiceByIdAsync(int id);
        Task<bool> CreateServiceAsync(ServiceViewModel model);
        Task<bool> UpdateServiceAsync(ServiceViewModel model);
        Task<bool> DeleteServiceAsync(int id);
    }
}