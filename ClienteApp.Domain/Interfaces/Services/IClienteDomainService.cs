using ClientesApp.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Métodos de serviço de domínio para usuário
    /// </summary>
    public interface IClienteDomainService
    {
        void CadastrarCliente(Cliente cliente);

        void EditarCliente(Cliente cliente);

        void ExcluirCliente(Guid id);

        List<Cliente> ConsultarClientes();

        Cliente? GetById(Guid id);
    }
}
