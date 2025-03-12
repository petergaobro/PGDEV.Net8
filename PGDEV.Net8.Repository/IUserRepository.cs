using PGDEV.Net8.Model;

namespace PGDEV.Net8.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> Query();
    }
}
