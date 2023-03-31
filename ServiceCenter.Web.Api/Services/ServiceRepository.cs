using ServiceCenter.Web.Api.Models;

namespace ServiceCenter.Web.Api.Services
{
    public class ServiceRepository : IServiceRepository
    {
        public ValueTask<Service> DeleteServicesAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Service> InsertServicesAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IQueryable<Service>> SelectServicesAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Service> SelectServicesAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Service> UpdateServicesAsync(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
