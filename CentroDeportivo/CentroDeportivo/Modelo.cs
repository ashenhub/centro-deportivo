using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CentroDeportivo
{
	public class Modelo
	{
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private Usuario usuarioAux;

        public Modelo()
        {
        }

        public void DatosMock()
        {
            ActividadRealizada a1, a2; //Añadir sobrecarga en Usuario que permita añadir actividad para pruebas

            a1 = new ActividadRealizada("ciclismo", new DateTime(2023, 09, 22));
            a2 = new ActividadRealizada("entrenamiento funcional", new DateTime(2023, 07, 12));

            listaUsuarios.Add(new Usuario("12345", "Persona1", "Ape1 Ape2",
                new DateTime(2000, 09, 12), true, "Femenino"));
            listaUsuarios.Add(new Usuario("67890A", "Persona2", "Ape1",
                new DateTime(1999, 08, 20), false, "Masculino"));
        }

        //public IReadOnlyList<Usuario> ListaUsuarios => listaUsuarios.AsReadOnly();
        public List<Usuario> ListaUsuarios
        {
            get {
                return listaUsuarios;
            }
        }

        public bool ValidarUsuario(string codigo)
        {
            usuarioAux = listaUsuarios.Find(u => u.Codigo == codigo);

            if (usuarioAux == null)
                return false;
            else
                return true;
        }

        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            listaUsuarios.Add(nuevoUsuario);   
        }

        public void RegistrarActividad(string nombreActividad, DateTime fechaRealizacion)
        {
            ActividadRealizada actividad = new ActividadRealizada(nombreActividad, fechaRealizacion);
            usuarioAux.AgregarActividadRealizada(actividad);
        }

        public void EliminarUsuario()
        {
            listaUsuarios.Remove(usuarioAux);
        }

        public bool ModificarSocio()
        {
            if (usuarioAux.EsSocio == true)
            {
                usuarioAux.EsSocio = false;
                return false;
            }
            else
            {
                usuarioAux.EsSocio = true;
                return true;
            }
        }
    }
}

