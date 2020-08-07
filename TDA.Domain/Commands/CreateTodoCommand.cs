using System;

namespace TDA.Domain.Commands
{
    public class CreateTodoCommand
    {
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
    }
}