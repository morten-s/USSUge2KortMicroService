

  using System;
  using System.Linq;
  using Microsoft.AspNetCore.Builder;
  using Microsoft.Extensions.DependencyInjection;
  using Polly;

  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      // services.Scan(selector => selector
      //   .FromAssemblyOf<Startup>()
      //   .AddClasses(c => c.Where(t => t != typeof(ProductCatalogClient) && t.GetMethods().All(m => m.Name != "<Clone>$")))
      //   .AsImplementedInterfaces());
      // services.AddHttpClient<IProductCatalogClient, ProductCatalogClient>()
      //   .AddTransientHttpErrorPolicy(p =>
      //     p.WaitAndRetryAsync(
      //       3,
      //       attempt => TimeSpan.FromMilliseconds(100 * Math.Pow(2, attempt))));
      services.AddControllers();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
  }
