using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Person
    {
        public Name PersonName { get; set; }  // объект Name
        public int Height { get; set; }       // рост в см

        public Person() 
        { 
            PersonName = new Name();
        }

        public Person(Name name, int height)
        {
            PersonName = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"{PersonName} {Height}";
        }
    }
}
