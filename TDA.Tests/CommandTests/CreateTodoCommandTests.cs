using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Commands;

namespace TDA.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Command Title test", "TestUser", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void If_an_invalid_command()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void If_a_valid_command()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}