using System.ComponentModel.DataAnnotations;

namespace CrudProdutos.WebAPI.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Digite a conta de usuário.")]
        public string ContaUsuario { get; set; }

        public string Senha { get; set; }
    }
}