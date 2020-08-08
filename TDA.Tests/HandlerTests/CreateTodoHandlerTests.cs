using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDA.Domain.Commands;
using TDA.Domain.Handlers.Contracts;
using TDA.Domain.Repositories;

namespace TDA.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        [TestMethod]
        public void If_an_invalid_command_should_stop_the_execution()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void If_a_valid_command_should_continue_the_execution()
        {
            Assert.Fail();
        }
    }
}