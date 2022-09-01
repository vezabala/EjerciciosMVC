using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class EstudianteProfesor : Entity
    {
        public string EstudianteId { get; private set; }

        public string ProfesorId { get; private set; }
        public EstudianteProfesor(string id,string estudianteId, string profesorId) : base(id)
        {
            this.EstudianteId = estudianteId;
            this.ProfesorId = profesorId;
        }
    }
}
