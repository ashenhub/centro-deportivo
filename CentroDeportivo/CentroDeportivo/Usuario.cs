using System;
namespace CentroDeportivo
{
	public class Usuario
	{
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsSocio { get; set; } //true=socio, false=noSocio
        public int Sexo { get; set; } //valor del indice del picker 0=Femenino 1=Masculino
        //Necesita una coleccion para guardar visitas [actividad - fecha] 

        public Usuario()
		{
		}

        public Usuario(string codigo, string nombre, string apellidos, DateTime fechaNacimiento, bool esSocio, int sexo)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.EsSocio = esSocio;
            this.Sexo = sexo;
        }
	}
}

