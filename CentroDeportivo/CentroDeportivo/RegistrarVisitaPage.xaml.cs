using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroDeportivo
{
    public partial class RegistrarVisitaPage : ContentPage
    {
        private Modelo modeloUsuarios;
        public RegistrarVisitaPage(Modelo modeloUsuarios)
        {
            InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
        }
        private void AltaActividad_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            string actividad = actividadEntry.Text;
            DateTime fechaActual = DateTime.Now;
        
            modeloUsuarios.AñadirActividad(codigo, actividad, fechaActual);
        }
    }
}

