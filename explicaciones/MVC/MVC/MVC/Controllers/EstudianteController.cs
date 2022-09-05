using MVC.Models;
using MVC.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    internal class EstudianteController
    {
        private IVista<Estudiante> vista;

        public EstudianteController(IVista<Estudiante> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string name, Escuela escuela)
        {
            Estudiante estudiante;

            //Creacion del objeto estudiante
            estudiante = Estudiante.Build(id, name, escuela);

            this.vista.Render(estudiante);
        }
    }
}
