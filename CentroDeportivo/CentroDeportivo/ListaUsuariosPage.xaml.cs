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
            if (e.SelectedItem is Usuario selectedUsuario)
                await Navigation.PushAsync(new DetalleUsuarioPage(selectedUsuario));

           ((ListView)sender).SelectedItem = null;
        }
    }
}


