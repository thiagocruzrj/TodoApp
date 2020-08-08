using TDA.Domain.Entities;
using TDA.Domain.Repositories;

namespace TDA.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo) { }

        public void Update(TodoItem todo) { }
    }
}