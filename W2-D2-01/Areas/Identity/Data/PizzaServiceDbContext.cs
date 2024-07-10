using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using W2_D2_01.Areas.Identity.Data;

namespace W2_D2_01.Areas.Identity.Data;

public class PizzaServiceDbContext : IdentityDbContext<PizzaServiceUser>
{
    public PizzaServiceDbContext(DbContextOptions<PizzaServiceDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new PizzaServiceUserConfiguration());
    }
}

public class PizzaServiceUserConfiguration : IEntityTypeConfiguration<PizzaServiceUser>
{
    public void Configure(EntityTypeBuilder<PizzaServiceUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
    } 
}