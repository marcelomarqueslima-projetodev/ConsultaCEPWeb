using ConsultaCEPWeb.Domain;
using ConsultaCEPWeb.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ConsultaCEPWeb.Repository
{
    public class EnderecoRepository : RepositoryConnector, IEnderecoRepository
    {
        public EnderecoRepository(IConfiguration config) : base(config) { }
        public void Add(Endereco obj)
        {
            throw new System.NotImplementedException();
        }

        public Endereco Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Endereco> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Endereco obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Endereco obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
