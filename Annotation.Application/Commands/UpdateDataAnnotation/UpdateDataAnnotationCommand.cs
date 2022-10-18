using MediatR;

namespace Annotation.Application.Commands.UpdateDataAnnotation
{
    public class UpdateDataAnnotationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string SystemName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
