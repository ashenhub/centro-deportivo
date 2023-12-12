using System;
using System.Text.RegularExpressions;
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
            string actividad;
            DateTime fechaActual = pickerFechaActividad.Date;
            string patronDNI = @"^\d{8}[a-zA-Z]$";

            if (string.IsNullOrEmpty(codigo))
                await DisplayAlert("Aviso", "El DNI no puede estar vacío", "OK");

     

            else if (Regex.IsMatch(codigo, patronDNI) == true)
            {
                if (!modeloUsuarios.ValidarUsuario(codigo)) {
                    await DisplayAlert("Aviso", "El DNI introducido no se encuentra registrado", "OK");
                }
                else if (actividadPicker.SelectedIndex < 0) {
                    await DisplayAlert("Aviso", "Por favor, seleccione una actividad", "OK");
                }
                else
                {
                    actividad = actividadPicker.SelectedItem.ToString();
                    modeloUsuarios.RegistrarActividad(actividad, fechaActual);
                    await DisplayAlert("Éxito", "La actividad fue registrada correctamente", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Formato de DNI incorrecto", "OK");
            }
        }
    }
}

