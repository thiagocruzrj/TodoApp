using System;

namespace TDA.Domain.Entities
{
    public class Todo : Entity
    {
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
    }
}