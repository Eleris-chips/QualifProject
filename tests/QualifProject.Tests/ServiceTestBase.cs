using Microsoft.Extensions.DependencyInjection;
using QualifProject.Application;
using QualifProject.Domain;
using QualifProject.Infrastructure;

namespace QualifProject.Tests;

[TestClass]
public abstract class ServiceTestBase<TService>
    where TService : class
{
    #region Protected Properties

    /// <summary>
    /// The service to test.
    /// </summary>
    protected TService Service { get; private set; } = null!;

    /// <summary>
    /// Le provider de services.
    /// </summary>
    protected IServiceProvider ServiceProvider { get; private set; } = null!;

    #endregion Protected Properties

    #region Public Methods

    /// <summary>
    /// Initialisation des tests.
    /// </summary>
    [TestInitialize]
    public void Initialize()
    {
        var serviceCollection = new ServiceCollection()
            .AddApplicationDependencies()
            .AddDomainDependencies()
            .AddInfrastructureDependencies();

        ServiceProvider = serviceCollection.BuildServiceProvider();
        Service = ServiceProvider.GetRequiredService<TService>();
    }

    #endregion Public Methods
}