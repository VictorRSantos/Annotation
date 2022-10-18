using Annotation.Core.Entities;

namespace Annotation.Core.Repositories
{
    public interface IDataAnnotationRepository
    {
        Task<List<DataAnnotation>> GetAllAsync();
        Task<DataAnnotation> GetByIdAsync(int id);
        Task AddAsync(DataAnnotation data);
        Task Delete(DataAnnotation data);
        Task SaveChangesAsync();

    }
}
