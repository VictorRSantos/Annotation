using Annotation.Core.Repositories;
using MediatR;

namespace Annotation.Application.Commands.UpdateDataAnnotation
{
    public class UpdateDataAnnotationCommandHandler : IRequestHandler<UpdateDataAnnotationCommand, Unit>
    {
        private readonly IDataAnnotationRepository _dataAnnotationRepository;
        public UpdateDataAnnotationCommandHandler(IDataAnnotationRepository dataAnnotationRepository)
        {
            _dataAnnotationRepository = dataAnnotationRepository;
        }
        public async Task<Unit> Handle(UpdateDataAnnotationCommand request, CancellationToken cancellationToken)
        {
            var annotation = await _dataAnnotationRepository.GetByIdAsync(request.Id);

            annotation.Update(request.SystemName, request.Login, request.Password, request.Description);

            await _dataAnnotationRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
