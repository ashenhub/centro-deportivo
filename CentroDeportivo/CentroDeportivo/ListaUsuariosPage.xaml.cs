using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CentroDeportivo
{	
	public partial class ListaUsuariosPage : ContentPage
	{
        private Modelo modeloUsuarios;
        public ListaUsuariosPage(Modelo modeloUsuarios)
		{
            InitializeComponent();
            this.modeloUsuarios = modeloUsuarios;
            BindingContext = modeloUsuarios;
            //JODER VAYA MIERDONN AAAAAAAAAAAAAAAAA
        }
	}
}

