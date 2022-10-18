using Annotation.Application.Queries.GetByIdDataAnnotation;
using Annotation.Application.ViewModels;
using Annotation.Core.Repositories;
using MediatR;

namespace Annotation.Application.Queries.GetDataAnnotationById
{
    public class GetDataAnnotationByIdQueryHanlder : IRequestHandler<GetDataAnnotationByIdQuery, DataAnnotationViewModel>
    {
        private readonly IDataAnnotationRepository _dataAnnotationRepository;
        public GetDataAnnotationByIdQueryHanlder(IDataAnnotationRepository dataAnnotationRepository)
        {
            _dataAnnotationRepository = dataAnnotationRepository;
        }

        public async Task<DataAnnotationViewModel> Handle(GetDataAnnotationByIdQuery request, CancellationToken cancellationToken)
        {
            var dataAnnotation = await _dataAnnotationRepository.GetByIdAsync(request.Id);

            if (dataAnnotation is null) return null;

            var dataAnnotationViewModel = new DataAnnotationViewModel(dataAnnotation.Id, dataAnnotation.SystemName, dataAnnotation.Login, dataAnnotation.Password, dataAnnotation.Description);

            return dataAnnotationViewModel;
        }
    }
}
