using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session_Five;

public class EmployeeProjectsConfig : IEntityTypeConfiguration<EmployeeProjects>
{
    public void Configure(EntityTypeBuilder<EmployeeProjects> builder)
    {
        builder.HasKey(e => new { e.ProjectId , e.EmpId});

        builder.HasOne(ep => ep.Project)
            .WithMany(p => p.EmployeeProjects)
            .HasForeignKey(e => e.ProjectId);

        builder.HasOne(ep => ep.Employee)
            .WithMany(p => p.EmployeeProjects)
            .HasForeignKey(ep => ep.EmpId);
    }
}
