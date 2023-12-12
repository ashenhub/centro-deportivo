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

        public List<Usuario> ListaUsuarios
        {
            get
            {
                return listaUsuarios;
            }
        }

        public void DatosMock()
        {
            ActividadRealizada a1, a2, a3, a4;

            a1 = new ActividadRealizada("Ciclismo", new DateTime(2023, 09, 22));
            a2 = new ActividadRealizada("Entrenamiento Funcional", new DateTime(2023, 07, 12));
            a3 = new ActividadRealizada("Yoga", new DateTime(2023, 05, 10));
            a4 = new ActividadRealizada("Actividad Libre", new DateTime(2023, 05, 10));

            listaUsuarios.Add(new Usuario("12345678A", "Juan", "López García", new DateTime(1995, 05, 20), true, "Masculino", a1, a3, a4));
            listaUsuarios.Add(new Usuario("00000000B", "María", "Martínez Pérez", new DateTime(1988, 11, 03), false, "Femenino", a2, a1, a4));
            listaUsuarios.Add(new Usuario("11111111C", "Carlos", "Fernández Rodríguez", new DateTime(2002, 03, 15), true, "Masculino", a3, a2, a4));
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

