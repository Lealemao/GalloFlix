using System.ComponentModel.DataAnnotations;

namespace GalloFlix.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por Favor informe um email.")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por Favor informe sua senha.")]
    public string Password { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool RememberMe { get; set; }
    
    public string ReturnUrl { get; set; }
}
