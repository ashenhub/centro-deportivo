using System;
using System.Collections.Generic;

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

            if (!modeloUsuarios.ValidarUsuario(codigo))
                await DisplayAlert("Aviso", "El código introducido no se encuentra registrado", "OK");
      
            else
            {
                modeloUsuarios.EliminarUsuario();
                await DisplayAlert("Éxito", "Se eliminó el usuario y su historial", "OK");
            }
            
        }

    }
}

