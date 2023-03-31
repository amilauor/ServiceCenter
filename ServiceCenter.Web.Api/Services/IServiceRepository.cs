using ServiceCenter.Web.Api.Models;

namespace ServiceCenter.Web.Api.Services
{
    public interface IServiceRepository
    {
        IQueryable<Service> SelectServices();
        ValueTask<Service> SelectServicesAsync(Guid Id);
        ValueTask<Service> InsertServicesAsync(Service service);
        ValueTask<Service> UpdateServicesAsync(Service service);
        ValueTask<Service> DeleteServicesAsync(Guid Id);

    }
}
