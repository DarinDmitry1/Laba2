using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Name
    {
        // setter getter 
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }

        // конструкторы

        public Name() { }

        public Name(string lastName)
        {
            LastName = lastName;
        }

        public Name(string lastName, string firstName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name(string lastName, string firstName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public override string ToString()
        {
            return string.Join(" ", new[] { LastName, FirstName, Patronymic } .Where(s => !string.IsNullOrEmpty(s)));
        }
    }
}
