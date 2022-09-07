using MVCWEB.Data;
using MVCWEB.Models;

namespace MVCWEB.Services
{
    public class EscuelaServices
    {
        private readonly IRepositoy repositoy;

        public EscuelaServices(IRepositoy repositoy)
        {
            this.repositoy = repositoy;
        }

        public async Task Crear(Escuela escuela)
        {
            //comprobar parametros
            if(escuela is null)
                throw new Exception("Escuela es nula");

            await this.repositoy.Save(escuela);
            await this.repositoy.Commit();
        }

        public async Task<List<Escuela>> GetAllEscuelas()
        {
            return await this.repositoy.GetAll<Escuela>();
        }
    }
}
