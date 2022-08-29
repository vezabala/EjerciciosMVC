using PatronesDeDiseño.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Fabricas
{
    internal class Factory : IFactory
    {
        public Entity buildEstudiante(int id)
        {
            return new Estudiante(id);
        }

        public Entity buildProfesor(int id, string ingreso)
        {
            return new Profesor(id, ingreso);
        }
    }
}
