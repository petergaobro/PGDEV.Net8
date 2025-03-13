using PGDEV.Net8.Model;

namespace PGDEV.Net8.IService
{
    public interface IBaseServices<TEntity, TVo> where TEntity : class
    {
        Task<List<TVo>> Query();
    }
}