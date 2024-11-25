using System.Collections.ObjectModel;
using BusReservation_Maui.MVVM.Models;

namespace BusReservation_Maui.MVVM.ViewModels;

public class UsuarioViewModel
{
    public ObservableCollection<Usuario> Usuarios { get; set; }
    public UsuarioViewModel()
    {
        Usuarios = new ObservableCollection<Usuario>()
        {
            new Usuario
            {
                UsuarioId = 1, Nombre = "Juan Pérez", Email = "juan.perez@example.com", Telefono = "123456789"
            }
        };
    }
}