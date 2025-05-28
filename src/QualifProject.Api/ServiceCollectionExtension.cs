using QualifProject.Application;
using QualifProject.Business;
using QualifProject.Infrastructure;

namespace QualifProject.Api;

public static class ServiceCollectionExtension
{
    #region Public Methods

    public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        => services
        .AddApplicationDependencies()
        .AddBusinessDependencies()
        .AddInfrastructureDependencies()
        ;

    #endregion Public Methods
}