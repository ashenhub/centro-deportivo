using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CentroDeportivo
{
	public class Modelo
	{
        private List<Usuario> listaUsuarios = new List<Usuario>();

        //public IReadOnlyList<Usuario> ListaUsuarios => listaUsuarios.AsReadOnly();

        public Modelo()
		{
		}

        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            //falta hacer la comprobación de que exista o no
            listaUsuarios.Add(nuevoUsuario);
            MostrarMensaje("Bienvenido", "Usuario añadido correctamente");
        }

        public void EliminarUsuario(String codigo)
        {
            Usuario usuarioAEliminar = listaUsuarios.Find(u => u.Codigo == codigo);
            if (usuarioAEliminar != null)
            {
                // Elimina el usuario de la lista
                listaUsuarios.Remove(usuarioAEliminar);
                MostrarMensaje("Usuario eliminado", "Usuario eliminado correctamente");
            }
            else
            {
                // Ya veremos como manejar estas cosas
                MostrarMensaje("Usuario no encontrado", "El usuario proporcionado no se encuentra registrado");
            }

        }

        public void AñadirActividad (String codigo, string nombreActividad, DateTime fechaRealizacion)
        {
            ActividadRealizada actividad = new ActividadRealizada(nombreActividad, fechaRealizacion);

            Usuario usuarioAModificar = listaUsuarios.Find(u => u.Codigo == codigo);
            if (usuarioAModificar.EsSocio == true)
            {
                if (usuarioAModificar != null)
                {
                    //Añade la nueva actividad al usuario 
                    usuarioAModificar.AgregarActividadRealizada(actividad);
                    MostrarMensaje("Actividad añadida", "La actividad se añadió con exito");
                }
                else
                {
                    // Ya veremos como manejar estas cosas
                    MostrarMensaje("Usuario no encontrado", "El usuario proporcionado no se encuentra registrado");
                }
            }
            else
            {
                //throw new InvalidOperationException("Este usuario no es socio");
                MostrarMensaje("Usuario no socio", "El usuario proporcionado no es socio");
            }

        }

        public void ModificarSocio(String codigo)
        {
           
            Usuario usuarioAModificar = listaUsuarios.Find(u => u.Codigo == codigo);
            if (usuarioAModificar != null)
            {
                if(usuarioAModificar.EsSocio == true)
                {
                    usuarioAModificar.EsSocio = false;
                    MostrarMensaje("Cambio realizado", "El usuario ya no es socio");
                }
                else
                {
                    usuarioAModificar.EsSocio = true;
                    MostrarMensaje("Cambio realizado", "Bienvenido de nuevo");
                }
            }
            else
            {

                //throw new InvalidOperationException("No se encontró ningún usuario con el código proporcionado.");
                MostrarMensaje("Usuario no encontrado", "El usuario proporcionado no se encuentra registrado");
            }

        }


        private void MostrarMensaje(string titulo, string mensaje)
        {
            // Utiliza tu servicio de mensajes o la lógica de visualización de mensajes aquí
            // Por ejemplo, usando DisplayAlert en Xamarin.Forms
            // Esto asume que estás dentro de una Page de Xamarin.Forms
            if (Application.Current.MainPage is Page currentPage)
            {
                currentPage.DisplayAlert(titulo, mensaje, "OK");
            }
        }
    }
}

