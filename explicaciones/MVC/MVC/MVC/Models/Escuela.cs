using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class Escuela : Entity
    {
        public string Direccion { get; set; }

        public List<Estudiante> Estudiantes { get; private set; }

        public Escuela (string id, string direccion) :base(id)
        {
            Direccion = direccion;
            Estudiantes = new List<Estudiante> ();
        }

        public void AddEstudiantes(Estudiante estudiante)
        {
            this.Estudiantes.Add(estudiante);
        }
    }
}
