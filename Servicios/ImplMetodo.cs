using RepasoFech.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoFech.Servicios
{
    internal class ImplMetodo:InterfazMetodo
    {
        public void darAlta(List<ActividadDto>listaActividades)
        {
            ActividadDto actividades = pedirDatos();  
            
            listaActividades.Add(actividades);
        }

        private ActividadDto pedirDatos()
        {
            ActividadDto actividades=new ActividadDto();

            Console.Write("\n\tIntroduzca el nombre de la actividad: ");
            actividades.Nombre = Console.ReadLine();

            Console.Write("\n\tIntroduzca la fecha de inicio: ");
            actividades.FechInicio=Convert.ToDateTime(Console.ReadLine());

            actividades.FechaFin=DateTime.Now;

            TimeSpan diferencia = actividades.FechaFin - actividades.FechInicio;
            actividades.Min = diferencia.Minutes;

            return actividades;
        }

        public void mostrarActividades(List<ActividadDto> listaActividades)
        {
            ActividadDto actividades =new ActividadDto();

            foreach(ActividadDto actividadDto in listaActividades)
            {
                actividades = actividadDto;
                Console.WriteLine(actividades.ToString());
            }
        }

        public void borrarActividad(List<ActividadDto> listaActividades)
        {
            ActividadDto actividadDto =new ActividadDto();

            foreach(ActividadDto actividadDto1 in listaActividades)
            {
                actividadDto = actividadDto1;

                Console.WriteLine("\n\tNombre: " + actividadDto.Nombre);
                Console.WriteLine("\tMinutos: " + actividadDto.Min+"\n");
            }

            Console.Write("\n\tIntroduzca el nombre de la actividad que quiere borrar: ");
            string nombre = Console.ReadLine();

            
            foreach(ActividadDto actividadDto1 in listaActividades)
            {
               
                if (actividadDto1.Nombre.Equals(nombre))
                {
                    actividadDto = actividadDto1;
                    
                }
            }
            listaActividades.Remove(actividadDto);

        }
    }
}
