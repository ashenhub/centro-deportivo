using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class AltaUsuarioPage : ContentPage
	{
        private Modelo modeloUsuarios;
        public AltaUsuarioPage(Modelo modeloUsuarios)
        {
			InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
		}

        private void AltaUsuario_Clicked(object sender, EventArgs e)
        {
            // Recopila datos del usuario desde la interfaz de usuario
            string codigo = codigoEntry.Text;
            string nombre = nombreEntry.Text;
            string apellidos = apellidoEntry.Text;
            int sexo = pickerSexo.SelectedIndex;
            DateTime fechaNacimiento = pickerFechaNacimiento.Date;
            bool esSocio = socioSwitch.IsToggled;
            // Crea un nuevo objeto Usuario
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellidos = apellidos,
                Codigo = codigo,
                Sexo = sexo,
                FechaNacimiento = fechaNacimiento,
                EsSocio = esSocio
            };

            // Agrega el usuario a la lista, esta lista piensoque debería estar
            // en un modelo o en la clase usuario para asi tener los datos compartidos
            modeloUsuarios.AgregarUsuario(nuevoUsuario);
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            nombreEntry.Text = string.Empty;
            apellidoEntry.Text = string.Empty;
            codigoEntry.Text = string.Empty;

        }
    }
}

