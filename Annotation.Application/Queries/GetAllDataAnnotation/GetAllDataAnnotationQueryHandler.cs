using Annotation.Application.ViewModels;
using Annotation.Core.Repositories;
using MediatR;

namespace Annotation.Application.Queries.GetAllDataAnnotation
{
    public class GetAllDataAnnotationQueryHandler : IRequestHandler<GetAllDataAnnotationQuery, List<DataAnnotationViewModel>>
    {
        private readonly IDataAnnotationRepository _dataAnnotationRepository;
        public GetAllDataAnnotationQueryHandler(IDataAnnotationRepository dataAnnotationRepository)
        {
            _dataAnnotationRepository = dataAnnotationRepository;
        }

        public async Task<List<DataAnnotationViewModel>> Handle(GetAllDataAnnotationQuery request, CancellationToken cancellationToken)
        {
            var dataAnnotation = await _dataAnnotationRepository.GetAllAsync();

            return dataAnnotation.Select(d => new DataAnnotationViewModel(d.Id, d.SystemName, d.Login, d.Password, d.Description)).ToList();

        }
    }
}
