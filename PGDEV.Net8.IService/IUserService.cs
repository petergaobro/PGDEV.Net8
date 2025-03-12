using PGDEV.Net8.Model;

namespace PGDEV.Net8.IService
{
    public interface IUserService
    {
        Task<List<UserVo>> Query();
    }
}
