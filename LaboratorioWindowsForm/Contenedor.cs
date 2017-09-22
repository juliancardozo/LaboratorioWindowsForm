using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioWindowsForm
{
    public class Contenedor
    {
        public ArrayList alumnos { get; set; }

        public Contenedor()
        {
            alumnos = new ArrayList();
        }

        public void Agregar(String nom, String apellido)
        {
            alumnos.Add(new Alumno(nom, apellido));
        }
    }
}
