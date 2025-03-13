using AutoMapper;
using PGDEV.Net8.IService;
using PGDEV.Net8.Model;
using PGDEV.Net8.Repository;

namespace PGDEV.Net8.Service
{
    public class BaseServices<TEntity, TVo> : IBaseServices<TEntity, TVo> where TEntity : class, new()
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseServices(IMapper mapper, IBaseRepository<TEntity> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        public async Task<List<TVo>> Query()
        {
            // var baseRepo = new BaseRepository<TEntity>();
            var entities = await _baseRepository.Query();
            var llout = _mapper.Map<List<TVo>>(entities);
            return llout;
        }
    }
}
