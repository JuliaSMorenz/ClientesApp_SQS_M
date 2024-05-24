using System.ComponentModel.DataAnnotations;

namespace ClientesApp.API.DTO.Request
{
    /// <summary>
    /// Modelo de dados para a requisição de criação de usuário
    /// </summary>
    public class CriarUsuarioRequestDTO
    {
        [MinLength(5, ErrorMessage = "Por favor, informe um nome com no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe um nome com no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe um nome de usuário.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um endreço de e-mail válido.")]
        [Required(ErrorMessage = "Por favor, informe o e-mail do usuário.")]
        public string? Email { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        [Required(ErrorMessage = "Por favor, informe um número de CPF.")]
        public string? Cpf { get; set; }
    }
}
