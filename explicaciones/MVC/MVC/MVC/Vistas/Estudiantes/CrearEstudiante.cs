using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Vistas.Estudiantes
{
    internal class CrearEstudiante : IVista<Estudiante>
    {
        public void Render(Estudiante obj)
        {
            Console.WriteLine($"Se a creado el estudiante con el nombre {obj.Name}");
        }
    }
}
