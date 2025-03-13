using Newtonsoft.Json;
using PGDEV.Net8.Model;
using System.Text.Json.Serialization;

namespace PGDEV.Net8.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public async Task<List<TEntity>> Query()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\": 18,\"Name\":\"namenamename\"}]";
            return JsonConvert.DeserializeObject<List<TEntity>>(data) ?? new List<TEntity>();
        }
    }

}
