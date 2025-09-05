using project_cls.DAL.DataAcess_Contracts;
using project_cls.DAL.DataAccess.Repositories;
namespace project_cls.DAL.DataAccess
{
    public static class DataAccessRegistration
    {
        public static IServiceCollection RegisterDataAccess(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>();
            services.AddScoped<IUnitofWork, UnitofWork>();

            return services;
        }
    }
}
