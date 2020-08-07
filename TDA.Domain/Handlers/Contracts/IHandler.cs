using TDA.Domain.Commands.Contracts;

namespace TDA.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
         
    }
}