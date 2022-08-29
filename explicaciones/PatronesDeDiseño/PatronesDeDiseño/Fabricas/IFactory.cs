using PatronesDeDiseño.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Fabricas
{
    internal interface IFactory
    {
        public Entity buildEstudiante(int id);

        public Entity buildProfesor(int id, string ingreso);
    }
}
