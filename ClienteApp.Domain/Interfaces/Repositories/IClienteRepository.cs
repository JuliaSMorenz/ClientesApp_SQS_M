using ClientesApp.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface de repositório de dados para a entidade Cliente
    /// </summary>
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);

        public List<Cliente> GetAll();
        public Cliente? GetById(Guid id);
        public Cliente? GetByCpf(string cpf);
    }
}
