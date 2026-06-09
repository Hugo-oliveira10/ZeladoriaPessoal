using Microsoft.EntityFrameworkCore;
using ZeladoriaUrbana.Application.Services.Chamados;
using ZeladoriaUrbana.Domain.Repositories;
using ZeladoriaUrbana.Infrastructure.DataAccess.Context;
using ZeladoriaUrbana.Infrastructure.DataAccess.Repositories;

namespace ZeladoriaUrbana.Api.DependencyInjection;

public static class ServicesInjection
{
    public static IServiceCollection AddProjectServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(
                configuration.GetConnectionString(
                    "DefaultConnection"
                )
            );
        });

        services.AddScoped<
            IChamadoRepository,
            ChamadoRepository
        >();

        services.AddScoped<CreateChamadoService>();

        return services;
    }
}