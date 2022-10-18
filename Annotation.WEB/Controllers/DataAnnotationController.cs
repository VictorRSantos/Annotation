using Annotation.Application.Commands.CreateDataAnnotation;
using Annotation.Application.Commands.DeleteDataAnnotation;
using Annotation.Application.Commands.UpdateDataAnnotation;
using Annotation.Application.Queries.GetAllDataAnnotation;
using Annotation.Application.Queries.GetByIdDataAnnotation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Annotation.WEB.Controllers
{
    public class DataAnnotationController : Controller
    {
        private readonly IMediator _mediator;

        public DataAnnotationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View(_mediator.Send(new GetAllDataAnnotationQuery()).Result);
        }

        [HttpGet]
        public IActionResult NewDataAnnotation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDataAnnotation(CreateDataAnnotationCommand command)
        {
            _mediator.Send(command);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateDataAnnotation(int id)
        {

            var updateDataAnnotation =_mediator.Send(new GetDataAnnotationByIdQuery(id)).Result;

            return View(updateDataAnnotation);

        }

        [HttpPost]
        public IActionResult UpdateDataAnnotation(UpdateDataAnnotationCommand command)
        {
            var updateDataAnnotation = _mediator.Send(command);

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleteDataAnnotation = _mediator.Send(new DeleteDataAnnotationCommand(id));

            return RedirectToAction(nameof(Index));
        }
    }
}
