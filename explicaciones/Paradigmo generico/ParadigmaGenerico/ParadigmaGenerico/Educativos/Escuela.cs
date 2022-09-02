using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmaGenerico.Educativos
{
    internal class Escuela<T> : IEscuela<T> where T : Entity
    {
        private List<T> Matriculados { get; set; }

        public void Matricular(T obj)
        {
            obj.Id = "123";

            Matriculados.Add(obj);
        }
    }
}
