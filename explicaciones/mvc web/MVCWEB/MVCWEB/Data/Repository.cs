using Microsoft.EntityFrameworkCore;
using MVCWEB.Models;

namespace MVCWEB.Data
{
    public class Repository : IRepositoy
    {
        private readonly MVCWEBContext context;

        public Repository(MVCWEBContext context)
        {
            this.context = context;
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public void Delete<T>(T obj) where T : Entity
        {
            context.Set<T>().Remove(obj);
        }

        public async Task<List<T>> GetAll<T>() where T : Entity
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task Save<T>(T obj) where T : Entity
        {
            await context.Set<T>().AddAsync(obj);
        }

        public void Update<T>(T obj) where T : Entity
        {
            context.Set<T>().Update(obj);
        }
    }
}
