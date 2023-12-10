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

        async private void AltaActividad_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            string actividad = actividadPicker.SelectedItem.ToString();
            DateTime fechaActual = DateTime.Now;

            if (string.IsNullOrEmpty(actividad))
            {
                await DisplayAlert("Aviso", "Aviso: por favor introduzca una actividad", "OK");

            }

            else if (!modeloUsuarios.ValidarUsuario(codigo))
                await DisplayAlert("Aviso", "El código introducido no se encuentra registrado", "OK");

            else
            {

                modeloUsuarios.RegistrarActividad(actividad, fechaActual);

                await DisplayAlert("Éxito", "La actividad fue registrada correctamente", "OK");
              
            }
            
        }
    }
}

