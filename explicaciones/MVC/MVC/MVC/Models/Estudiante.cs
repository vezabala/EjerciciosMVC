using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class Estudiante : Entity
    {
        public string Name { get; private set; }

        public Escuela Escuela { get; private set; }

        public List<EstudianteProfesor> EstudianteProfesors { get; private set; }

        public Estudiante(string id, string name, Escuela escuela) : base(id)
        {
            Name = name;
            Escuela = escuela;
            EstudianteProfesors = new();
        }

        public void AddProfesor(string profesorId)
        {
            this.EstudianteProfesors.Add(
                new EstudianteProfesor(
                id: Guid.NewGuid().ToString(),
                estudianteId: this.Id, 
                profesorId: profesorId));
        }
    }
}
