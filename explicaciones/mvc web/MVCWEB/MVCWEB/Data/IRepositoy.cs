using MVCWEB.Models;

namespace MVCWEB.Data
{
    public interface IRepositoy
    {
        public void Save<T>(T obj) where T : Entity;

        public void Delete<T>(T obj) where T : Entity;

        public void Update<T>(T obj) where T : Entity;

        public List<T> GetAll<T>() where T : Entity;
    }
}
