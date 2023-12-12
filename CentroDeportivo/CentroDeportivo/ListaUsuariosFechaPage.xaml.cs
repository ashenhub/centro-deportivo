using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CentroDeportivo
{
    public partial class ListaUsuariosFechaPage : ContentPage
    {
        private Modelo modeloUsuarios;
        private List<Usuario> listaUsuariosAux = new List<Usuario>();
        private Usuario usuarioAux;
        private DateTime fechaActividad;


        public ListaUsuariosFechaPage(Modelo modeloUsuarios)
        {
            InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
        }

        async private void BuscarFecha_Clicked(object sender, EventArgs e)
        {
            listaUsuariosAux.Clear();
            usuariosFechaListView.IsVisible = false;
            fechaActividad = pickerFechaActividad.Date;

            foreach (Usuario usuario in modeloUsuarios.ListaUsuarios)
            {
                foreach (ActividadRealizada actividadRealizada in usuario.ActividadesRealizadas)
                {
                    if (actividadRealizada.FechaRealizacion == fechaActividad)
                    {
                        usuarioAux = usuario;

                        if (!listaUsuariosAux.Contains(usuarioAux))
                            listaUsuariosAux.Add(usuarioAux);
                    }
                }
            }
            usuariosFechaListView.ItemsSource = new ObservableCollection<Usuario>(listaUsuariosAux);
            

            if (listaUsuariosAux.Count == 0)
                await DisplayAlert("Aviso", "No se encontraron usuarios para esa fecha", "OK");

            else
                usuariosFechaListView.IsVisible = true;
        }

        async private void usuariosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Usuario selectedUsuario)
                await Navigation.PushAsync(new DetalleUsuarioFechaPage(selectedUsuario, fechaActividad));

            ((ListView)sender).SelectedItem = null;
        }
    }
}
