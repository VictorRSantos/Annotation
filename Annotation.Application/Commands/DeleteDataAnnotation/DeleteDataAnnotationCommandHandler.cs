using Annotation.Core.Repositories;
using MediatR;

namespace Annotation.Application.Commands.DeleteDataAnnotation
{
    public class DeleteDataAnnotationCommandHandler : IRequestHandler<DeleteDataAnnotationCommand, Unit>
    {
        private readonly IDataAnnotationRepository _dataAnnotationRepository;
        public DeleteDataAnnotationCommandHandler(IDataAnnotationRepository dataAnnotationRepository)
        {
            _dataAnnotationRepository = dataAnnotationRepository;
        }
        public async Task<Unit> Handle(DeleteDataAnnotationCommand request, CancellationToken cancellationToken)
        {
            var dataAnnotation = await _dataAnnotationRepository.GetByIdAsync(request.Id);

            await _dataAnnotationRepository.Delete(dataAnnotation);

            await _dataAnnotationRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
