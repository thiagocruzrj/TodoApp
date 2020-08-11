using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TDA.Domain.Commands;
using TDA.Domain.Entities;
using TDA.Domain.Handlers.Contracts;
using TDA.Domain.Repositories;

namespace TDA.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAll([FromServices]ITodoRepository repository)
        {
            return repository.GetAll("TestUser");
        }

        [Route("done")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllDone([FromServices]ITodoRepository repository)
        {
            return repository.GetAllDone("TestUser");
        }


        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody]CreateTodoCommand command, [FromServices] TodoHandler handler)
        {
            command.User = "TestUser";
            return (GenericCommandResult)handler.Handler(command);
        }
    }
}