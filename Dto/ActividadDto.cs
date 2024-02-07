using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoFech.Dto
{
    internal class ActividadDto
    {
        //Atributos 
        string nombre = "aaaaa";
        DateTime fechInicio;
        DateTime fechaFin=DateTime.Now;
        int min;



        //Constructores
        public ActividadDto(string nombre, DateTime fechInicio, DateTime fechaFin, int min)
        {
            this.nombre = nombre;
            this.fechInicio = fechInicio;
            this.fechaFin = fechaFin;
            this.min = min;
        }

        public ActividadDto()
        {
        }

        //Getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechInicio { get => fechInicio; set => fechInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int Min { get => min; set => min = value; }

        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\nNombre: " + this.nombre +
                "\nFechInicio: " + this.fechInicio +
                "\nFechaFin: " + this.FechaFin +
                "\nMinutos: " + this.min;

            return mensaje;
        }

    }
}
