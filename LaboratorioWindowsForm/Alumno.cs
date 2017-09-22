using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioWindowsForm
{
    public class Alumno
    {
        public String  Nombre { get; set; }
        public String  Apellido { get; set; }

        public Alumno (String nombre, String apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
