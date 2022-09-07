using MVCWEB.Data;
using MVCWEB.Models;

namespace MVCWEB.Services
{
    public class EstudianteServices
    {
        private readonly IRepositoy repositoy;

        public EstudianteServices(IRepositoy repositoy)
        {
            this.repositoy = repositoy;
        }

        public async Task Crear(Estudiante estudiante)
        {
            //comprobar parametros
            if (estudiante is null)
                throw new Exception("Estudiante es nula");

            await this.repositoy.Save(estudiante);
            await this.repositoy.Commit();
        }

        public async Task<List<Estudiante>> GetAllEstudiantes()
        {
            return await this.repositoy.GetAll<Estudiante>();
        }
    }
}
