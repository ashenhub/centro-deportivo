using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class ListaUsuariosPage : ContentPage
	{
        private Modelo modeloUsuarios;
        public ListaUsuariosPage(Modelo modeloUsuarios)
		{
            InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
            MostrarUsuariosEnListView();
        }

        private void MostrarUsuariosEnListView()
        {
            usuariosListView.ItemsSource = modeloUsuarios.ListaUsuarios;
        }

        private async void OnUsuarioSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Aquí puedes manejar la selección del usuario
            if (e.SelectedItem is Usuario selectedUsuario)
                await Navigation.PushAsync(new DetalleUsuarioPage(selectedUsuario));

           // Deselecciona el elemento del ListView
           ((ListView)sender).SelectedItem = null;
        }
    }
}


