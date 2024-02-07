using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoFech.Servicios
{
    internal class ImplMenu:InterfazMenu
    {
        public void mostrarMensaje()
        {
            string mensaje = "Bienvenido a mi programa";
            Console.WriteLine("\n\t\t"+mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("\n\tMenu:");
            Console.WriteLine("\n\t1.-Darde alta actividad");
            Console.WriteLine("\n\t2.-Mostrar actividad");
            Console.WriteLine("\n\t3.-Eliminar actividad");
            Console.WriteLine("\n\t0.-Salir");

            opcion= Console.ReadKey(true).KeyChar - ('0');

            return opcion;

        }
    }
}
