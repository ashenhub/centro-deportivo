using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class ModificarSocioPage : ContentPage
	{
        private Modelo modeloUsuarios;

        public ModificarSocioPage (Modelo modeloUsuarios)
		{
			InitializeComponent ();
            this.modeloUsuarios = modeloUsuarios;
        }

        async private void Modificar_Clicked(object sender, EventArgs e)
        {
            bool socio;
            string codigo = codigoEntry.Text;
            string patronDNI = @"^\d{8}[a-zA-Z]$";

            if (string.IsNullOrEmpty(codigo))
                await DisplayAlert("Aviso", "El DNI no puede estar vacío", "OK");

            

            else if (Regex.IsMatch(codigo, patronDNI) == true)
            {
                if (!modeloUsuarios.ValidarUsuario(codigo))
                {
                    await DisplayAlert("Aviso", "El DNI introducido no se encuentra registrado", "OK");
                }
                else
                {
                    socio = modeloUsuarios.ModificarSocio();

                    if (socio)
                        await DisplayAlert("Éxito", "Cambio realizado: el usuario ahora es socio", "OK");
                    else
                        await DisplayAlert("Éxito", "Cambio realizado: el usuario ya no es socio", "OK");
                }
            } else
            {
                await DisplayAlert("Error", "Formato de DNI incorrecto", "OK");
            }
        }
    }
}

