using Annotation.Application.ViewModels;
using MediatR;

namespace Annotation.Application.Queries.GetAllDataAnnotation
{
    public class GetAllDataAnnotationQuery : IRequest<List<DataAnnotationViewModel>>
    {
        public GetAllDataAnnotationQuery()
        {
        }


    }
}
