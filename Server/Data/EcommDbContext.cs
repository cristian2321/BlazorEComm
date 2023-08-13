using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data;

public class EcommDbContext : DbContext
{
    public EcommDbContext(DbContextOptions<EcommDbContext> dbContextOptions): base(dbContextOptions)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new()
            {
                Id = Guid.NewGuid(),
                Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4",
                Title = "The Hitchhiker's Guide to the Galaxy",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m
            },

            new()
            {
                Id = Guid.NewGuid(),
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. ",
                Title = "Ready Player One",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                Price = 7.99m
            },

            new()
            {
                Id = Guid.NewGuid(),
                Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwel",
                Title = "Nineteen Eighty-Four",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg",
                Price = 8.99m
            });
    }

    public DbSet<Product> Products => Set<Product>();
}
