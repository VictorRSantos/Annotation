using Annotation.Core.Entities;
using Annotation.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Annotation.Infrastructure.Persistence.Repositories
{
    public class DataAnnotationRepository : IDataAnnotationRepository
    {
        private readonly AnnotationDbContext _annotationDbContext;
        public DataAnnotationRepository(AnnotationDbContext annotationDbContext)
        {
            _annotationDbContext = annotationDbContext;
        }

        public async Task AddAsync(DataAnnotation data)
        {
            await _annotationDbContext.DataAnnotations.AddAsync(data);

            await _annotationDbContext.SaveChangesAsync();
        }

        public async Task<List<DataAnnotation>> GetAllAsync()
        {
            return await _annotationDbContext.DataAnnotations.ToListAsync();
        }

        public async Task<DataAnnotation> GetByIdAsync(int id)
        {
            return await _annotationDbContext.DataAnnotations.SingleAsync(d => d.Id == id);
        }

        public Task Delete(DataAnnotation data)
        {
            var dataAnnotation = _annotationDbContext.DataAnnotations.Remove(data);

            return Task.FromResult(dataAnnotation);
        }


        public async Task SaveChangesAsync()
        {
            await _annotationDbContext.SaveChangesAsync();
        }
    }
}
