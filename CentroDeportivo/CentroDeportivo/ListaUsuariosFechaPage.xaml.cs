using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CentroDeportivo
{
    public partial class ListaUsuariosFechaPage : ContentPage
    {
        private Modelo modeloUsuarios;
        public ListaUsuariosFechaPage(Modelo modeloUsuarios)
        {
            InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;


        }

        private void BuscarFecha_Clicked(object sender, EventArgs e)
        {
            DateTime fechaActividad = pickerFechaActividad.Date;
            List<Usuario> usuariosEnFecha = ObtenerUsuariosEnFecha(fechaActividad);
            actividadListView.ItemsSource = usuariosEnFecha;


        }

        private List<Usuario> ObtenerUsuariosEnFecha(DateTime fecha)
        {
            // Filtra la lista de usuarios según las actividades realizadas en la fecha
            return modeloUsuarios.ListaUsuarios
                .Where(usuario => usuario.ActividadesRealizadas.Any(actividad => actividad.FechaRealizacion.Date == fecha.Date))
                .ToList();
        }



    }
}
