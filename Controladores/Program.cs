/*Supongamos que estás desarrollando una aplicación para el registro de actividades diarias. Esta aplicación 
 * tendrá las siguientes opciones: dar de alta una actividad, mostrar una actividad concreta en base al nombre 
 * de la actividad, eliminar actividad en base al nombre de la actividad. Cada actividad tiene un nombre, una 
 * fecha de inicio, una fecha de fin y una duración en minutos.


Pide al usuario que ingrese el nombre de una actividad.
Pide al usuario que ingrese la fecha de inicio de la actividad.
La fecha de fin de la actividad será el instante en el que se guarde la actividad que se está dando de alta.
Con la fecha de inicio y fecha de fin calcula la duración en minutos de la actividad.

Eliminar actividad:
Al seleccionar eliminar actividad, lo primero que se verá será un listado de actividades con los campos nombre 
y duración en minutos de la actividad.*/

using RepasoFech.Dto;
using RepasoFech.Servicios;

namespace RepasoFech.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMenu menu = new ImplMenu();
            InterfazMetodo metodo=new ImplMetodo();

            List<ActividadDto> listaActividades= new List<ActividadDto>();

            bool salir = false;
            int opcionSeleccionada;

            while (!salir)
            {
                opcionSeleccionada=menu.mostrarMenu();

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("\n\tHa seleccionado la opción para salir !!");
                        salir = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\tHas seleccionado la opción para dar de alta una actividad");
                        metodo.darAlta(listaActividades);
                        break;

                    case 2:
                        Console.WriteLine("\n\tHas seleccionado al opción de mostrar las actividades ");
                        metodo.mostrarActividades(listaActividades);
                        break;

                    case 3:
                        Console.WriteLine("\n\tHas seleccionado la opción de eleminiar actividad");
                        metodo.borrarActividad(listaActividades);
                        break;

                    default:
                        Console.WriteLine("\n\t¡¡ Opción seleccionada incorrecta !!");
                        break;

                }
            }

        }
    }
}
