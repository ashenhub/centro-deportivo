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
            //JODER VAYA MIERDONN AAAAAAAAAAAAAAAAA
        }


        private void MostrarUsuariosEnListView()
        {
            // Crea un ListView y establece su origen de datos como la lista de usuarios del modelo.
            var listView = new ListView
            {
                ItemsSource = modeloUsuarios.ListaUsuarios,
                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "Nombre");
                    textCell.SetBinding(TextCell.DetailProperty, "Apellidos");
                    return textCell;
                })
            };
            listView.ItemSelected += OnUsuarioSelected; // Asocia el manejador de eventos
            // Agrega el ListView al contenido de la página.
            Content = new StackLayout
            {
                Children = { listView }
            };
        }

        private void OnUsuarioSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Aquí puedes manejar la selección del usuario
            if (e.SelectedItem is Usuario selectedUsuario)
            {
                // Realiza las acciones necesarias con el usuario seleccionado
                DisplayAlert("Usuario Seleccionado", $"Nombre: {selectedUsuario.Nombre}\nApellidos: {selectedUsuario.Apellidos}", "OK");
            }

           // Deselecciona el elemento del ListView
           ((ListView)sender).SelectedItem = null;
        }
    }
}


