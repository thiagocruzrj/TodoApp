using System;
using System.Collections.Generic;
using TDA.Domain.Entities;
using TDA.Domain.Repositories;

namespace TDA.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo) { }
        public void Update(TodoItem todo) { }
        public TodoItem GetById(Guid Id, string user) { return new TodoItem("Test Title", DateTime.Now, "Test User"); }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetUndone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }
    }
}