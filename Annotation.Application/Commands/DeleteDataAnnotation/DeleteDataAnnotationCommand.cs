using MediatR;

namespace Annotation.Application.Commands.DeleteDataAnnotation
{
    public class DeleteDataAnnotationCommand : IRequest<Unit>
    {
        public DeleteDataAnnotationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
