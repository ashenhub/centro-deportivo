using System;
using System.Collections.Generic;

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

            if (!modeloUsuarios.ValidarUsuario(codigo))
                await DisplayAlert("Aviso", "El usuario proporcionado no se encuentra registrado", "OK");

            else
            {
                socio = modeloUsuarios.ModificarSocio();

                if (socio)
                    await DisplayAlert("Cambio realizado", "El usuario ahora es socio", "OK");
                else
                    await DisplayAlert("Cambio realizado", "El usuario ya no es socio", "OK");
            }
        }
    }
}

