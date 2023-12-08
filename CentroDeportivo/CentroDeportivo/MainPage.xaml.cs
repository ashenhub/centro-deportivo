﻿using System;
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
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void AltaBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AltaUsuarioPage());
        }

        async void RegistrarBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegistrarVisitaPage());
        }

        async void ListadoBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuariosPage());
        }

        async void ListadoFechaBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuariosFechaPage());
        }

        async void ModificarSocioBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ModificarSocioPage());
        }

        async void EliminarBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EliminarUsuarioPage());
        }
    }
}

