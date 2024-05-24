using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Infra.Data.Entities
{
    /// <summary>
    /// Modelo de entidade para cliente
    /// </summary>
    public class Cliente
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataHoraCadastro { get; set; }

        #endregion
    }
}
