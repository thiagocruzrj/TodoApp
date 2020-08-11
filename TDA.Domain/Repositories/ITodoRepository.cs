using System;
using System.Collections.Generic;
using TDA.Domain.Entities;

namespace TDA.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid Id, string user);
        IEnumerable<TodoItem> GetAll(string user);
        IEnumerable<TodoItem> GetDone(string user);
        IEnumerable<TodoItem> GetUndone(string user);
        IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done);
    }
}