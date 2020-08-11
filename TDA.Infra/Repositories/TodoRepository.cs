using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TDA.Domain.Entities;
using TDA.Domain.Repositories;
using TDA.Infra.Contexts;

namespace TDA.Infra.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(TodoItem todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(Guid Id, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done)
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

        public void Update(TodoItem todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}