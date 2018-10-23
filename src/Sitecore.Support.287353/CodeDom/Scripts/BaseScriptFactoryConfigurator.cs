namespace Sitecore.Support.CodeDom.Scripts
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.Abstractions;
  using Sitecore.DependencyInjection;
  using System.Linq;

  public class BaseScriptFactoryConfigurator : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      var existingScriptFactoryDescriptor = serviceCollection.FirstOrDefault(x => x.ServiceType == typeof(BaseScriptFactory));

      if (existingScriptFactoryDescriptor != null)
      {
        serviceCollection.Remove(existingScriptFactoryDescriptor);
      }

      serviceCollection.Add(ServiceDescriptor.Singleton(typeof(BaseScriptFactory), typeof(DefaultScriptFactory)));
    }
  }
}