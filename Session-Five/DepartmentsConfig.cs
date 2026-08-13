using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session_Five;

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
