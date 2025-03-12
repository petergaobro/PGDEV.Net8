using Newtonsoft.Json;
using PGDEV.Net8.Model;
using System.Text.Json.Serialization;

namespace PGDEV.Net8.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> Query()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\": 18,\"Name\":\"petergaodev\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();
        }
    }
}
