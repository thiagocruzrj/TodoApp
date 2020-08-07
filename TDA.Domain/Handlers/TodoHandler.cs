using Flunt.Notifications;
using TDA.Domain.Commands;
using TDA.Domain.Commands.Contracts;
using TDA.Domain.Repositories;

namespace TDA.Domain.Handlers.Contracts
{
    public class TodoHandler : Notifiable, IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handler(CreateTodoCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}