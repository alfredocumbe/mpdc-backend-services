namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("ApiDatabase")).
        UseSnakeCaseNamingConvention();
       // options.UseLazyLoadingProxies();
    }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<Image> AssetImages { get; set; }
    public DbSet<OtherDescription> AssetDescriptions { get; set; }
    public DbSet<Warranty> Warranties { get; set; }
}