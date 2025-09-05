using project_cls.DAL;
using project_cls.DAL.DataAccess.Repositories;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Service_Contracts;
using project_cls.Service_layer;
using project_cls.Service_layer.Service;
using project_cls.DAL.DataAccess;
using project_cls.Controllers;

namespace project_cls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //uilder.Services.AddTransient<IProductService, ProductService>();
            //builder.Services.AddTransient<IProductService, ProductService>();
            //builder.Services.AddTransient<IUnitofWork, UnitofWork>();
            //builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.RegisterService();
            builder.Services.RegisterDataAccess();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddTransient(typeof(IBaseRepo<>),typeof(BaseRepo<>));
            // builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();


            // builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();

            app.UseAuthorization();


            app.MapControllers();

                        //app.MapCategoryEndpoints();

            app.Run();
        }
    }
}
