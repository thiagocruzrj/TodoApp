using Flunt.Notifications;
using TDA.Domain.Commands;
using TDA.Domain.Commands.Contracts;
using TDA.Domain.Entities;
using TDA.Domain.Repositories;

namespace TDA.Domain.Handlers.Contracts
{
    public class TodoHandler : Notifiable, IHandler<CreateTodoCommand>, IHandler<UpdateTodoCommand>, IHandler<MarkTodoAsDoneCommand>, IHandler<MarkTodoAsUndoneCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handler(CreateTodoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, your task is invalid!", command.Notifications);

            var todo = new TodoItem(command.Title, command.Date, command.User);

            _repository.Create(todo);

            return new GenericCommandResult(true, "Task saved", todo);
        }

        public ICommandResult Handler(UpdateTodoCommand command)
        {
            command.Validate();
            if(command.Invalid)
                return new GenericCommandResult(false, "Ops, your task is invalid!", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);

            _repository.Update(todo);

            return new GenericCommandResult(true, "Task saved", todo);
        }

        public ICommandResult Handler(MarkTodoAsUndoneCommand command)
        {
            command.Validate();
            if(command.Invalid)
                return new GenericCommandResult(false, "Ops, your task is invalid!", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            _repository.Update(todo);

            return new GenericCommandResult(true, "Task saved", todo); 
        }

        public ICommandResult Handler(MarkTodoAsDoneCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}