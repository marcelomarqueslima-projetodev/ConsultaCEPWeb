using Microsoft.Extensions.Configuration;

namespace ConsultaCEPWeb.Repository
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnetion()
        {
            return _configuration.GetSection("Connection").GetSection("ConnectionString").Value;
        }
    }
}
