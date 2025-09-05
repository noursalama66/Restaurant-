using project_cls.Service_layer.Contracts;
using project_cls.Service_layer.Service;
using project_cls.Service_layer.Service_Contracts;

namespace project_cls.Service_layer
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IBillService, BillService>();






            return services;
        }

    }
}
