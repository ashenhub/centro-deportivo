using System;
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

        async private void AltaUsuario_Clicked(object sender, EventArgs e)
        {
            string codigo = codigoEntry.Text;
            string nombre = nombreEntry.Text;
            string apellidos = apellidoEntry.Text;
            DateTime fechaNacimiento = pickerFechaNacimiento.Date;
            string sexo = "";
            if (pickerSexo.SelectedIndex >= 0)
                sexo = pickerSexo.SelectedItem.ToString();
            bool esSocio = socioSwitch.IsToggled;

            if (string.IsNullOrEmpty(codigo))
                await DisplayAlert("Aviso", "El código no puede estar vacío", "OK");

            else if (string.IsNullOrEmpty(nombre))
                await DisplayAlert("Aviso", "El nombre no puede estar vacío", "OK");

            else if (string.IsNullOrEmpty(apellidos))
                await DisplayAlert("Aviso", "El apellido no puede estar vacío", "OK");

            else if (string.IsNullOrEmpty(sexo))
                await DisplayAlert("Aviso", "El sexo no puede estar vacío", "OK");

            else if (modeloUsuarios.ValidarUsuario(codigo))
                await DisplayAlert("Aviso", "Usuario no añadido: el código ya existe en el sistema", "OK");
            
            else
            {
                Usuario nuevoUsuario = new Usuario(codigo, nombre, apellidos, fechaNacimiento, esSocio, sexo);
                modeloUsuarios.AgregarUsuario(nuevoUsuario);
                LimpiarCampos();
                await DisplayAlert("Éxito", "Usuario añadido correctamente", "OK");
            } 
        }

        private void LimpiarCampos()
        {
            nombreEntry.Text = string.Empty;
            apellidoEntry.Text = string.Empty;
            codigoEntry.Text = string.Empty;
            pickerFechaNacimiento.Date = DateTime.Now;
            pickerSexo.SelectedIndex = -1;
            socioSwitch.IsToggled = true;

        }
    }
}

