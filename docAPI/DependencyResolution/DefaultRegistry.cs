using AutoMapper;
using docAPI.Data.Concrete;
using docAPI.Data.Contracts;
using docAPI.Models.Entities;
using docAPI.Models.Projections;
using docAPI.Repository;
using docAPI.Repository.Concrete;
using docAPI.Repository.Contracts;
using StructureMap;
using StructureMap.Graph;

namespace docAPI.DependencyResolution
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<User, DbUser>().ForMember(dest => dest.AccessLevelID, opt => opt.MapFrom(source => (int)source.AccessLevel));
                //cfg.CreateMap<DbUser, User>().ForMember(dest => dest.AccessLevel, opt => opt.MapFrom(source => (AccessLevel)source.AccessLevelID));
                cfg.CreateMap<Tweet, TweetProjection>();
                cfg.CreateMap<TweetProjection, Tweet>();
            });

            var mapper = mapperConfig.CreateMapper();

            For<IMapper>().Use(mapper);
            For<IUserRepository>().Use<UserRepository>().Ctor<IMapper>().Is(mapper);
            For<ITweetDataService>().Use<SqliteTweetDataService>();
            For<ITweetService>().Use<TweetService>().Ctor<IMapper>().Is(mapper);
        }
    }
}