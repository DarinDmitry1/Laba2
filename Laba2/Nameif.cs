using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Nameif
    {
        // setter getter 
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }

        // конструкторы

        public Nameif() { }

        public Nameif(string lastName)
        {
            LastName = lastName;
        }
         
        public Nameif(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;

        }

        public Nameif(string lastName, string firstName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public override string ToString()
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(LastName))
                parts.Add(LastName!);

            if (!string.IsNullOrWhiteSpace(FirstName))
                parts.Add(FirstName);

            if (!string.IsNullOrWhiteSpace(Patronymic) && !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(FirstName))
                parts.Add(Patronymic!);

            return string.Join(" ", parts);
        }
    }
}
