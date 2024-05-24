namespace ClientesApp.API.DTO.Response
{
    /// <summary>
    /// Modelo de dados da resposta da exclusão de usuário
    /// </summary>
    public class ExcluirUsuarioResponseDTO
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
    }
}
