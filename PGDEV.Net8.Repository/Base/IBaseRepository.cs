using PGDEV.Net8.Model;

namespace PGDEV.Net8.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Query();
    }

}
