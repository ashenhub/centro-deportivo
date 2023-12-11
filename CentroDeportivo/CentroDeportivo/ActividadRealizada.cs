using System;

namespace CentroDeportivo
{
    public class ActividadRealizada
    {
        public string NombreActividad { get; set; }
        public DateTime FechaRealizacion { get; set; }

        public ActividadRealizada(String nombreActividad, DateTime fecha)
        {
            NombreActividad = nombreActividad;
            FechaRealizacion = fecha;
        }
    }
}