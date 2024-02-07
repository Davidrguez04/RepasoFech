using RepasoFech.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoFech.Servicios
{
    internal interface InterfazMetodo
    {
        public void darAlta(List<ActividadDto> listaActividades);

        public void mostrarActividades(List<ActividadDto> listaActividades);
        public void borrarActividad(List<ActividadDto> listaActividades);
    }
}
