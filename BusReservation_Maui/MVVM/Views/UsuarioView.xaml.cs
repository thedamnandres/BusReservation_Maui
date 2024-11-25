using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservation_Maui.MVVM.Models;
using BusReservation_Maui.MVVM.ViewModels;

namespace BusReservation_Maui.MVVM.Views;

public partial class UsuarioView : ContentPage
{
    public UsuarioView()
    {
        InitializeComponent(); 
        
        BindingContext = new UsuarioViewModel();
    }
}