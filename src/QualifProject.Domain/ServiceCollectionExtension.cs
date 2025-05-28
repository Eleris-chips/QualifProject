using Microsoft.Extensions.DependencyInjection;

namespace QualifProject.Domain;

public static class ServiceCollectionExtension
{
    #region Public Methods

    public static IServiceCollection AddDomainDependencies(this IServiceCollection services)
    => services;

    #endregion Public Methods
}