using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Commands;

namespace TDA.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void If_an_invalid_command()
        {
            var command = new CreateTodoCommand("","", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void If_a_valid_command()
        {
        }
    }
}