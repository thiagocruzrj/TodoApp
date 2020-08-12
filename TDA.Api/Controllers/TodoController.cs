using System;
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

        [Route("undone")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllUndone([FromServices]ITodoRepository repository)
        {
            return repository.GetAllUndone("TestUser");
        }

        [Route("done/today")]
        [HttpGet]
        public IEnumerable<TodoItem> GetDoneForToday([FromServices]ITodoRepository repository)
        {
            return repository.GetByPeriod("TestUser", DateTime.Now.Date, true);
        }

        [Route("done/tomorrow")]
        [HttpGet]
        public IEnumerable<TodoItem> GetDoneForTomorrow([FromServices]ITodoRepository repository)
        {
            return repository.GetByPeriod("TestUser", DateTime.Now.Date.AddDays(1), true);
        }

        [Route("undone/today")]
        [HttpGet]
        public IEnumerable<TodoItem> GetUndoneForToday([FromServices]ITodoRepository repository)
        {
            return repository.GetByPeriod("TestUser", DateTime.Now.Date, false);
        }

        [Route("undone/tomorrow")]
        [HttpGet]
        public IEnumerable<TodoItem> GetUndoneForTormorrow([FromServices]ITodoRepository repository)
        {
            return repository.GetByPeriod("TestUser", DateTime.Now.Date.AddDays(1), false);
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody]CreateTodoCommand command, [FromServices] TodoHandler handler)
        {
            command.User = "TestUser";
            return (GenericCommandResult)handler.Handler(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update([FromBody]UpdateTodoCommand command, [FromServices] TodoHandler handler)
        {
            command.User = "TestUser";
            return (GenericCommandResult)handler.Handler(command);
        }
    }
}