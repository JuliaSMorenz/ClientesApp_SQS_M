namespace ClientesApp.API.DTO.Response
{
    /// <summary>
    /// Modelo de dados da resposta da criação de usuário
    /// </summary>
    public class CriarUsuarioResponseDTO
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataHoraCadastro { get; set; }
    }
}
