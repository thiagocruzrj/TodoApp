using System;
using TDA.Domain.Entities;

namespace TDA.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid Id, string user);
    }
}