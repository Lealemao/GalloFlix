using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por Favor informe um email.")]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe a Data de Nascimento")]
    public DateTime Birthday { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Digite a senha")]
    [Required(ErrorMessage = "Por Favor informe a senha.")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Digite a senha novamente")]
    [Required(ErrorMessage = "Por Favor informe a senha.")]
    [Compare(nameof(Password), ErrorMessage = "A duas senhas devem coincidir")]
    public string ConfirmPassword { get; set; }
}
