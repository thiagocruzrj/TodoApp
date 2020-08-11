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
        IEnumerable<TodoItem> GetAll(string email);
        IEnumerable<TodoItem> GetDone(string email);
        IEnumerable<TodoItem> GetUndone(string email);
        IEnumerable<TodoItem> GetByPeriod(string email, DateTime date, bool done);
    }
}