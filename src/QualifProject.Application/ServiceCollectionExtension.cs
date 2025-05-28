using Microsoft.Extensions.DependencyInjection;
using QualifProject.Application.Services;
using QualifProject.Application.Services.Description;

namespace QualifProject.Application;

public static class ServiceCollectionExtension
{
    #region Public Methods

    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        => services
            .AddScoped<ITaskService, TaskService>()
        ;

    #endregion Public Methods
}