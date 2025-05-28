using Microsoft.Extensions.DependencyInjection;
using QualifProject.Application.Repositories;
using QualifProject.Infrastructure.Repository;

namespace QualifProject.Infrastructure;

public static class ServiceCollectionExtension
{
    #region Public Methods

    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        => services
            .AddScoped(typeof(IRepository<>), typeof(Repository<>));

    #endregion Public Methods
}