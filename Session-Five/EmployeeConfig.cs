
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Session_Five;

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .UseIdentityColumn(1, 1);


        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .HasColumnType("nvarchar")
            .HasColumnName("UserName");

        builder.Property(e => e.IsDeleted)
            .IsRequired();

        builder.HasOne(e => e.Role)
            .WithOne(r => r.Employee)
            .HasForeignKey<Employee>(e => e.RoleId);

        builder.HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DeptId);

    }
}
