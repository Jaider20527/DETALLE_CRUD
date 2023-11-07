using System.ComponentModel.DataAnnotations;

namespace DETALLE_CRUD.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
    }
}
