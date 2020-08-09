using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Entities;

namespace TDA.Tests.EntitiesTest
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem _todoItem = new TodoItem("Test Tittle", DateTime.Now, "Test User");
        [TestMethod]
        public void Has_new_todo_done_should_concluded()
        {
            Assert.AreEqual(_todoItem.Done, false);
        }
    }
}