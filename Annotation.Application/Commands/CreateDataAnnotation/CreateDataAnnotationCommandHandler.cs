using Annotation.Core.Entities;
using Annotation.Core.Repositories;
using MediatR;

namespace Annotation.Application.Commands.CreateDataAnnotation
{
    public class CreateDataAnnotationCommandHandler : IRequestHandler<CreateDataAnnotationCommand, int>
    {
        private readonly IDataAnnotationRepository _dataAnnotationRepository;
        public CreateDataAnnotationCommandHandler(IDataAnnotationRepository dataAnnotationRepository)
        {
            _dataAnnotationRepository = dataAnnotationRepository;
        }

        public async Task<int> Handle(CreateDataAnnotationCommand request, CancellationToken cancellationToken)
        {
            var dataAnnotation = new DataAnnotation(request.SystemName, request.Login,request.Password, request.Description);

            await _dataAnnotationRepository.AddAsync(dataAnnotation);

            return dataAnnotation.Id;

        }
    }
}
