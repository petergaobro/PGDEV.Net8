using PGDEV.Net8.IService;
using PGDEV.Net8.Model;
using PGDEV.Net8.Repository;

namespace PGDEV.Net8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            var userRepo = new UserRepository(); // Create an instance of UserRepository
            var users = await userRepo.Query();  // Asynchronously fetch user data
            return users.Select(d => new UserVo() { UserName = d.Name }).ToList(); // Transform and return
        }
    }
}
