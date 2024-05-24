namespace ClientesApp.API.DTO.Response
{
    /// <summary>
    /// Modelo de dados da resposta de edição de usuário
    /// </summary>
    public class EditarUsuarioResponseDTO
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
    }
}
