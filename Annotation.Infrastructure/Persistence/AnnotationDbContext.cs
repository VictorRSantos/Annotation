using Annotation.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Annotation.Infrastructure.Persistence
{
    public class AnnotationDbContext : DbContext
    {
        public AnnotationDbContext(DbContextOptions<AnnotationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<DataAnnotation> DataAnnotations { get; set; }
    }
}
