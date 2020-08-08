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
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Command Title test", "TestUser", DateTime.Now);
        private readonly TodoHandler _todoHandler = new TodoHandler(new FakeTodoRepository());

        public CreateTodoHandlerTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void If_an_invalid_command_should_stop_the_execution()
        {
            var result = (GenericCommandResult)_todoHandler.Handler(_invalidCommand);
            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void If_a_valid_command_should_continue_the_execution()
        {
            var result = (GenericCommandResult)_todoHandler.Handler(_validCommand);
            Assert.AreEqual(result.Success, true);
        }
    }
}