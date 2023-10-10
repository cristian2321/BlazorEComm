using BlazorEComm.Server.Data.SeedData;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data;

public class EcommDbContext : DbContext
{
    public EcommDbContext(DbContextOptions<EcommDbContext> dbContextOptions) : base(dbContextOptions) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductVariant>()
            .HasKey(x => new
            {
                x.ProductId,
                x.ProductTypeId
            });

        modelBuilder.Entity<CartItem>()
            .HasKey(x => new
            {
                x.UserId,
                x.ProductId,
                x.ProductTypeId
            });

        modelBuilder.Entity<OrderItem>()
            .HasKey(x => new
            {
                x.OrderId,
                x.ProductId,
                x.ProductTypeId
            });

        SeedData(modelBuilder);
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(CategorySeedData.GetCategories());

        modelBuilder.Entity<Product>().HasData(ProductSeedData.GetProducts());

        modelBuilder.Entity<ProductType>().HasData(ProductTypeSeedData.GetProductTypes());

        modelBuilder.Entity<ProductVariant>().HasData(ProductVariantSeedData.GetProductVariants());

        modelBuilder.Entity<Configuration>().HasData(ConfigurationSeedData.GetConfigurations());
    }

    public DbSet<ProductType> ProductTypes => Set<ProductType>();
   
    public DbSet<Product> Products => Set<Product>();
   
    public DbSet<ProductVariant> ProductVariants => Set<ProductVariant>();

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<User> Users => Set<User>();

    public DbSet<CartItem> CartItems => Set<CartItem>();

    public DbSet<Order> Orders => Set<Order>();

    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    public DbSet<Address> Addresses => Set<Address>();

    public DbSet<Configuration> Configurations => Set<Configuration>();

    public DbSet<Image> Images => Set<Image>();
}
