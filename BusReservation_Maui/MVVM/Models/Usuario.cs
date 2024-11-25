using System.ComponentModel.DataAnnotations;
namespace BusReservation_Maui.MVVM.Models;

public class Usuario
{
    [Key]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(60)]
    public string Nombre { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "El email es obligatorio")]
    public string Email { get; set; }

    [Phone]
    public string Telefono { get; set; }

    public ICollection<Reserva>? Reservas { get; set; } = new List<Reserva>();
}