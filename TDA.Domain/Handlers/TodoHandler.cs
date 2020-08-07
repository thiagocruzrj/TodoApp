using TDA.Domain.Commands;
using TDA.Domain.Commands.Contracts;

namespace TDA.Domain.Handlers.Contracts
{
    public class TodoHandler : IHandler<CreateTodoCommand>
    {
        public ICommandResult Handler(CreateTodoCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}