using searchtest.IServices;
using searchtest.ObjectMaps;
using searchtest.Services;
using WebApi.FreeSqlShared.Domains;

namespace searchtest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //T4CodeGenerator.T4Tools.WebApiGenerator.GenerateSingelProjectWebApi(typeof(BaseEntity<>));

            var builder = WebApplication.CreateBuilder(args);

            Func<IServiceProvider, IFreeSql> fsqlFactory = r =>
            {
                IFreeSql fsql = new FreeSql.FreeSqlBuilder()
                    .UseConnectionString(FreeSql.DataType.Sqlite, @"Data Source=freedb.db")
                    .UseMonitorCommand(cmd => Console.WriteLine($"Sql��{cmd.CommandText}"))//����SQL���
                    .UseAutoSyncStructure(true) //�Զ�ͬ��ʵ��ṹ�����ݿ⣬FreeSql����ɨ����򼯣�ֻ��CRUDʱ�Ż����ɱ�
                    .Build();
                return fsql;
            };
            builder.Services.AddSingleton<IFreeSql>(fsqlFactory);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(CustomProfile));

            builder.Services.AddTransient<IToDoItemService, ToDoItemService>();

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