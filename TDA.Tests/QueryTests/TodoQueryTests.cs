using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Entities;
using TDA.Domain.Queries;

namespace TDA.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("First task", DateTime.Now, "UserTest1"));    
            _items.Add(new TodoItem("Sec task", DateTime.Now, "UserTest2"));    
            _items.Add(new TodoItem("Third task", DateTime.Now, "UserTest3"));    
            _items.Add(new TodoItem("Fourth task", DateTime.Now, "UserTest4"));    
            _items.Add(new TodoItem("Fifth task", DateTime.Now, "UserTest5"));    
        }

        [TestMethod]
        public void When_execute_query_should_return_only_user_tasks()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("UserTest3"));
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void When_execute_query_should_return_only_user_done_tasks()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAllDone("UserTest3"));
            Assert.AreEqual(0, result.Count());
        }
    }
}