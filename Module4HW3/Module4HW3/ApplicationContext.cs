using Microsoft.EntityFrameworkCore;
using Module4HW3.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Module4HW3
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext(DbSet<Employee> employes, DbSet<EmployeeProject> employeeProjects, DbSet<Office> offices, DbSet<Project> projects, DbSet<Title> titles)
        {
            Employes = employes ?? throw new ArgumentNullException(nameof(employes));
            EmployeeProjects = employeeProjects ?? throw new ArgumentNullException(nameof(employeeProjects));
            Offices = offices ?? throw new ArgumentNullException(nameof(offices));
            Projects = projects ?? throw new ArgumentNullException(nameof(projects));
            Titles = titles ?? throw new ArgumentNullException(nameof(titles));
        }

        public ApplicationContext(DbContextOptions options)
    : base(options) => Database.EnsureCreated();

        public DbSet<Employee>? Employes { get; set; }

        public DbSet<EmployeeProject>? EmployeeProjects { get; set; }

        public DbSet<Office>? Offices { get; set; }

        public DbSet<Project>? Projects { get; set; }
        public DbSet<Title>? Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }
    }
}