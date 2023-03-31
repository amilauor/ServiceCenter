using ServiceCenter.Web.Api.Database;
using ServiceCenter.Web.Api.Models;

namespace ServiceCenter.Web.Api.Services
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ServiceDbContext context;
        private readonly ILogger<ServiceRepository> logger;
        public ServiceRepository(ServiceDbContext context, ILogger<ServiceRepository> logger) { 
            this.context = context;
            this.logger = logger;
        }

        public IQueryable<Service> SelectServices()
        {
            return this.context.Services.AsQueryable();
        }

        public ValueTask<Service> DeleteServicesAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Service> InsertServicesAsync(Service service)
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
