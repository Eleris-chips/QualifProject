using QualifProject.Application;
using QualifProject.Domain;
using QualifProject.Infrastructure;

namespace QualifProject.Api;

public static class ServiceCollectionExtension
{
    #region Public Methods

    public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        => services
        .AddApplicationDependencies()
        .AddDomainDependencies()
        .AddInfrastructureDependencies()
        ;

    #endregion Public Methods
}