namespace ClientesApp.API.DTO.Response
{
    /// <summary>
    /// Modelo de dados para a resposta de consulta de dados do usuário
    /// </summary>
    public class ObterDadosUsuarioResponseDTO
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataHoraCadastro { get; set; }
    }
}
