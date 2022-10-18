using Annotation.Application.ViewModels;
using MediatR;

namespace Annotation.Application.Queries.GetByIdDataAnnotation
{
    public class GetDataAnnotationByIdQuery : IRequest<DataAnnotationViewModel>
    {
        public GetDataAnnotationByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
