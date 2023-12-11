using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CentroDeportivo
{
    public partial class DetalleUsuarioPage : ContentPage
    {
        private Usuario usuario;

        public DetalleUsuarioPage(Usuario selectedUsuario)
        {
            InitializeComponent();

            usuario = selectedUsuario;
            BindingContext = usuario;
            MostrarDetalleUsuario();

        }

        private void MostrarDetalleUsuario()
        {
            nombreLabel.Text = $"Nombre: {usuario.Nombre}";
            apellidosLabel.Text = $"Apellidos: {usuario.Apellidos}";
            codigoLabel.Text = $"Código: {usuario.Codigo}";
            fechaNacLabel.Text = $"Fecha de Nacimiento: {usuario.FechaNacimiento}";
            sexoLabel.Text = $"Sexo: {usuario.Sexo}";

            if (usuario.EsSocio)
                socioLabel.Text = "Es Socio";
            else
                socioLabel.Text = "No es Socio";

            actividadListView.ItemsSource = usuario.ActividadesRealizadas;
        }
    }
}
