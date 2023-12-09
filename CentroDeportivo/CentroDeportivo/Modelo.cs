using System;
using System.Collections.Generic;

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
            listaUsuarios.Add(nuevoUsuario);
        }

        public void EliminarUsuario(String codigo)
        {
            Usuario usuarioAEliminar = listaUsuarios.Find(u => u.Codigo == codigo);
            if (usuarioAEliminar != null)
            {
                // Elimina el usuario de la lista
                listaUsuarios.Remove(usuarioAEliminar);
            }
            else
            {
                // Ya veremos como manejar estas cosas
                throw new InvalidOperationException("No se encontró ningún usuario con el código proporcionado.");
            }

        }

        public void AñadirActividad (String codigo, string nombreActividad, DateTime fechaRealizacion)
        {
            ActividadRealizada actividad = new ActividadRealizada(nombreActividad, fechaRealizacion);

            Usuario usuarioAModificar = listaUsuarios.Find(u => u.Codigo == codigo);
            if (usuarioAModificar != null)
            {
                //Añade la nueva actividad al usuario 
                usuarioAModificar.AgregarActividadRealizada(actividad);
            }
            else
            {
                // Ya veremos como manejar estas cosas
                throw new InvalidOperationException("No se encontró ningún usuario con el código proporcionado.");
            }

        }

        public List<Usuario> GetUsuarios()
        {
            return listaUsuarios;
        }
    }
}

