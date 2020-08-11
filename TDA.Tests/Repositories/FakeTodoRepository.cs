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
    }
}