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
        private void Modificar_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            modeloUsuarios.ModificarSocio(codigo);
        }
    }
}

