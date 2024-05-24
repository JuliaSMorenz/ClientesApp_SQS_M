using ClienteApp.Domain.Interfaces.Repositories;
using ClientesApp.Infra.Data.Contexts;
using ClientesApp.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Infra.Data.Repositories
{
    /// <summary>
    /// Classe de repositório para cliente.
    /// </summary>
    public class ClienteRepository : IClienteRepository
    {
        /// <summary>
        /// Método para adicionar um cliente no banco de dados
        /// </summary>
        public void Add(Cliente cliente)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Add(cliente);
                dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// Método para atualizar um cliente no banco de dados
        /// </summary>
        public void Update(Cliente cliente)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(cliente);
                dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// Método para excluir um cliente do bando de dados
        /// </summary>
        public void Delete(Cliente cliente)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(cliente);
                dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// Método para consultar todos os clientes
        /// </summary>
        public List<Cliente> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Cliente>().ToList();
            }
        }

        /// <summary>
        /// Método para retornar 1 cliente através do ID
        /// </summary>
        public Cliente? GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Cliente>().Find(id);
            }
        }

        /// <summary>
        /// Método para retornar 1 cliente através do CPF
        /// </summary>
        public Cliente? GetByCpf(string cpf)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Cliente>().Where(c => c.Cpf == cpf).FirstOrDefault();
            }
        }
    }
}
