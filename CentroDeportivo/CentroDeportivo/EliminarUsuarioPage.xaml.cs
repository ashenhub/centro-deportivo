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
        private void AltaUsuario_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            modeloUsuarios.EliminarUsuario(codigo);
        }

    }
}

