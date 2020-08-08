using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Commands;
using TDA.Domain.Handlers.Contracts;
using TDA.Domain.Repositories;
using TDA.Tests.Repositories;

namespace TDA.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        [TestMethod]
        public void If_an_invalid_command_should_stop_the_execution()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handler(command);
            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void If_a_valid_command_should_continue_the_execution()
        {
            var command = new CreateTodoCommand("Command Title Test", "UserTest", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handler(command);
            Assert.AreEqual(result.Success, true);
        }
    }
}