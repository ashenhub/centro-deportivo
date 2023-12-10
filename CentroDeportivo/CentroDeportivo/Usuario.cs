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
        public bool EsSocio { get; set; } //true=socio, false=noSocio
        public string Sexo { get; set; } //valor del indice del picker 0=Femenino 1=Masculino
        public List<ActividadRealizada> ActividadesRealizadas = new List<ActividadRealizada>(); //coleccion para guardar visitas [actividad - fecha] 

        public Usuario()
		{
		}

        //en Alta no hay que pasar la lista de actividades
        public Usuario(string codigo, string nombre, string apellidos, DateTime fechaNacimiento, bool esSocio, string sexo)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.EsSocio = esSocio;
            this.Sexo = sexo;
        }

        public void AgregarActividadRealizada(ActividadRealizada actividad)
        {
            ActividadesRealizadas.Add(actividad);
            
    }
}
}

