using System;
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

            if (string.IsNullOrEmpty(codigo))
                await DisplayAlert("Aviso", "El código no puede estar vacío", "OK");

            else if (!modeloUsuarios.ValidarUsuario(codigo))
                await DisplayAlert("Aviso", "El código introducido no se encuentra registrado", "OK");

            else
            {
                socio = modeloUsuarios.ModificarSocio();

                if (socio)
                    await DisplayAlert("Éxito", "Cambio realizado: el usuario ahora es socio", "OK");
                else
                    await DisplayAlert("Éxito", "Cambio realizado: el usuario ya no es socio", "OK");
            }
        }
    }
}

