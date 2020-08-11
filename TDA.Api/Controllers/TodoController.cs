using Microsoft.AspNetCore.Mvc;
using TDA.Domain.Commands;
using TDA.Domain.Handlers.Contracts;

namespace TDA.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody]CreateTodoCommand command, [FromServices] TodoHandler handler)
        {
            command.User = "TestUser";
            return (GenericCommandResult)handler.Handler(command);
        }
    }
}