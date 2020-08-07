using System;
using TDA.Domain.Commands.Contracts;

namespace TDA.Domain.Commands
{
    public class CreateTodoCommand : ICommand
    {
        public CreateTodoCommand() { }
        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }
        
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
    }
}