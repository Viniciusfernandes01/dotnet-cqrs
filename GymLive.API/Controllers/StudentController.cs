using GymLive.Application.Queries.GetStudents;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymLive.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            var getStudentsQuery = new GetStudentQuery();

            var result = await _mediator.Send(getStudentsQuery);

            return Ok(result);
        }
    }
}
