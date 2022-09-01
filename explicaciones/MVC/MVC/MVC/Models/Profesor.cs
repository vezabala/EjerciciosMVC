using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class Profesor : Entity
    {
        public string Cedula { get; private set; }

        public List<EstudianteProfesor> EstudianteProfesors { get; private set; }

        public Profesor(string id, string cedula) : base(id)
        {
            Cedula = cedula;
            EstudianteProfesors = new();
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
