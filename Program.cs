using EFCORE_MYSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        // Create builder and add MySQL database context
        builder.Services.AddDbContext<EFCoreDbContext>(
            options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("Conexao"),
                    new MySqlServerVersion(new Version(9, 2, 0))
                ),
            ServiceLifetime.Scoped
        );
        var app = builder.Build();
        app.Run();
    }
}
