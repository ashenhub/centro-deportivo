using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class EliminarUsuarioPage : ContentPage
	{
        private Modelo modeloUsuarios;

        public EliminarUsuarioPage (Modelo modeloUsuarios)
		{
			InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
		}

        async private void EliminarUsuario_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            string patronDNI = @"^\d{8}[a-zA-Z]$";


            if (string.IsNullOrEmpty(codigo))
                await DisplayAlert("Aviso", "El DNI no puede estar vacío", "OK");
            else if (Regex.IsMatch(codigo, patronDNI) == true)
            {
                if (!modeloUsuarios.ValidarUsuario(codigo))
                    await DisplayAlert("Aviso", "El DNI introducido no se encuentra registrado", "OK");

                else
                {
                    modeloUsuarios.EliminarUsuario();
                    await DisplayAlert("Éxito", "Se eliminó el usuario y su historial", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Formato de DNI incorrecto", "OK");
            }
        }
    }
}

