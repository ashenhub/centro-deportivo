using System;
using System.Collections.Generic;

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
            MostrarDetallesUsuario();
            MostrarActividades();

        }

        private void MostrarDetallesUsuario()
        {
            nombreLabel.Text = $"Nombre: {usuario.Nombre}";
            apellidosLabel.Text = $"Apellidos: {usuario.Apellidos}";
            codigoLabel.Text = $"Codigo: {usuario.Codigo}";
            sexoLabel.Text = $"Sexo: {usuario.Sexo}";
            socioLabel.Text = $"Es Socio: {usuario.EsSocio}";


        }

        private void MostrarActividades()
        {
            var listView = new ListView
            {
                ItemsSource = usuario.ActividadesRealizadas,
                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "NombreActividad");
                    textCell.SetBinding(TextCell.DetailProperty, "FechaRealizacion");
                    return textCell;
                })
            };

        }
    }
}
