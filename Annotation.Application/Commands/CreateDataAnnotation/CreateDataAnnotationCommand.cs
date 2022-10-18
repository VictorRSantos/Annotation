using MediatR;

namespace Annotation.Application.Commands.CreateDataAnnotation
{
    public class CreateDataAnnotationCommand : IRequest<int>
    {
        public string SystemName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

    }
}
