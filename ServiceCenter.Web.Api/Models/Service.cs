namespace ServiceCenter.Web.Api.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ServiceTypes Type { get; set; }

    }
}
