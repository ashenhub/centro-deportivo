using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CentroDeportivo
{
    public partial class MainPage : ContentPage

    {
        private Modelo modeloUsuarios;

        public MainPage()
        {
            InitializeComponent();
            modeloUsuarios = new Modelo();
            modeloUsuarios.DatosMock();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void AltaBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AltaUsuarioPage(modeloUsuarios));
        }

        async void RegistrarBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegistrarVisitaPage(modeloUsuarios));
        }

        async void ListadoBtn_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new ListaUsuariosPage(modeloUsuarios));
        }

        async void ListadoFechaBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuariosFechaPage(modeloUsuarios));
        }

        async void ModificarSocioBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ModificarSocioPage(modeloUsuarios));
        }

        async void EliminarBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EliminarUsuarioPage(modeloUsuarios));
        }
    }
}

