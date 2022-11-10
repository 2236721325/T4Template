

using WebApi.FreeSqlShared.Domains;

namespace TestApid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            T4CodeGenerator.T4Tools.WebApiGenerator.GenerateSingelProjectFreeSqlWebApi(typeof(BaseEntity<>));
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddAutoMapper(typeof(CustomProfile));
            //builder.Services.AddDbContextPool<MyDbContext>(options =>
            //{
            //    options.UseSqlite("Filename=Test.db");
            //});
            //builder.Services.AddTransient<IToDoItemService, ToDoItemService>();


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