using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TDA.Domain.Entities;
using TDA.Domain.Queries;
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
            return _context.Todos.AsNoTracking().Where(TodoQueries.GetAll(user)).OrderBy(x => x.Date);
        }

        public TodoItem GetById(Guid Id, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done)
        {
            return _context.Todos.AsNoTracking().Where(TodoQueries.GetByPeriod(user, date, done)).OrderBy(x => x.Date);
        }

        public IEnumerable<TodoItem> GetDone(string user)
        {
            return _context.Todos.AsNoTracking().Where(TodoQueries.GetAllDone(user)).OrderBy(x => x.Date);
        }

        public IEnumerable<TodoItem> GetUndone(string user)
        {
            return _context.Todos.AsNoTracking().Where(TodoQueries.GetAllUndone(user)).OrderBy(x => x.Date);
        }

        public void Update(TodoItem todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}