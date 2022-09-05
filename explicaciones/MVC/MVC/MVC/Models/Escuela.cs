using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Escuela : Entity
    {
        public string Direccion { get; set; }

        public List<Estudiante> Estudiantes { get; private set; }

        private Escuela (string id, string direccion) :base(id)
        {
            Direccion = direccion;
            Estudiantes = new List<Estudiante> ();
        }

        public static Escuela Build(string id, string direccion)
        {
            return new Escuela(id, direccion);
        }

        public void AddEstudiantes(Estudiante estudiante)
        {
            this.Estudiantes.Add(estudiante);
        }
    }
}
