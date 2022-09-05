using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Profesor : Entity
    {
        public string Cedula { get; private set; }

        public List<EstudianteProfesor> EstudianteProfesors { get; private set; }

        private Profesor(string id, string cedula) : base(id)
        {
            Cedula = cedula;
            EstudianteProfesors = new();
        }

        public static Profesor Build(string id, string cedula)
        {
            return new Profesor(id, cedula);
        }

        public void AddEstudiante(string estudianteId, string EstudianteName, Escuela escuela)
        {
            this.EstudianteProfesors.Add(
                new EstudianteProfesor(
                    Guid.NewGuid().ToString(), estudianteId, 
                    this.Id));
        }
    }
}
