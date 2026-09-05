using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_Five.Entities;

namespace Session_Five.Infrastructure;

public class DepartmentsConfig : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .UseIdentityColumn(1, 1);

        builder.Property(d => d.DepName)
            .HasMaxLength(50)
            .HasColumnName("Name");
        
    }
}
