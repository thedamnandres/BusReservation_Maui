using BusReservation_Maui.MVVM.Views;

namespace BusReservation_Maui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}