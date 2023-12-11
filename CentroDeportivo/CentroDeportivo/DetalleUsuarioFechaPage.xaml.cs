using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class DetalleUsuarioFechaPage : ContentPage
	{
        private Usuario usuarioAux;
		private DateTime fechaAux;
        private ActividadRealizada actividadAux;
        private List<ActividadRealizada> listaActividadesAux = new List<ActividadRealizada>();

        public DetalleUsuarioFechaPage (Usuario selectedUsuario, DateTime selectedFecha)
		{
			InitializeComponent ();

			usuarioAux = selectedUsuario;
			fechaAux = selectedFecha;

            MostrarActividadesPorFecha();

        }

        private void MostrarActividadesPorFecha()
        {
            foreach (ActividadRealizada actividadRealizada in usuarioAux.ActividadesRealizadas)
            {
                if (actividadRealizada.FechaRealizacion == fechaAux)
                {
                    actividadAux = actividadRealizada;

                    listaActividadesAux.Add(actividadAux);
                }
            }

            actividadFechaListView.ItemsSource = listaActividadesAux;
        }
    }
}

