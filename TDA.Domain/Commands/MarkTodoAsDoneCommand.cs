using Flunt.Notifications;
using TDA.Domain.Commands.Contracts;

namespace TDA.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}