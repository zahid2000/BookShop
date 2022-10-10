using BookShop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Infrastructure
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddInfastructureServices(this IServiceCollection seriveCollection, IConfiguration configuration)
        {
            seriveCollection.AddDbContext<BookShopDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            builderOptions => builderOptions.MigrationsAssembly(typeof(BookShopDbContext).Assembly.FullName)
            ));

            return seriveCollection;
        }
    }
}
