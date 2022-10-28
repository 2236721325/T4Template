
using Base.Shared.Domains;
using TestWebApi.ObjectMaps;
using Microsoft.EntityFrameworkCore;
using TestWebApi.Datas;
using TestWebApi.IServices;
using TestWebApi.Services;
using Autofac.Extensions.DependencyInjection;
using Autofac;

namespace TestWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WebApiGenerator.GenerateWebApi(typeof(BaseEntity<>));
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(CustomProfile));
            builder.Services.AddDbContextPool<MyDbContext>(options =>
            {
                options.UseSqlite("Filename=Test.db");
            });
            builder.Services.AddTransient<IPoemService, PoemService>();
            builder.Services.AddTransient<IUserService, UserService>();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule<TestWebApiModule>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}