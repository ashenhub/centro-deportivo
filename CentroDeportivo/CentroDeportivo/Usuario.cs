using System;
using System.Collections.Generic;

namespace CentroDeportivo
{
	public class Usuario
	{
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsSocio { get; set; } 
        public string Sexo { get; set; }
        public List<ActividadRealizada> ActividadesRealizadas { get; set; } = new List<ActividadRealizada>(); 

        public Usuario()
		{
		}

        public Usuario(string codigo, string nombre, string apellidos, DateTime fechaNacimiento, bool esSocio, string sexo)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.EsSocio = esSocio;
            this.Sexo = sexo;
        }

        public Usuario(string codigo, string nombre, string apellidos, DateTime fechaNacimiento, bool esSocio, string sexo,
                       ActividadRealizada a1, ActividadRealizada a2, ActividadRealizada a3)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.EsSocio = esSocio;
            this.Sexo = sexo;
            AgregarActividadRealizada(a1);
            AgregarActividadRealizada(a2);
            AgregarActividadRealizada(a3);
        }

        public void AgregarActividadRealizada(ActividadRealizada actividad)
        {
            ActividadesRealizadas.Add(actividad);
        }
    }
}

