using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class fPerson
    {
        public Name PersonName { get; set; }
        public int? Height { get; set; }
        public fPerson? Father { get; set; }

        public fPerson()
        {
            PersonName = new Name();
        }

        public fPerson(Name name, int? height = null, fPerson? father = null)
        {
            PersonName = name;
            Height = height;
            Father = father;
            FillMissingFromFather();
        }

        public void FillMissingFromFather()
        {
            if (Father == null) return;

            if (string.IsNullOrWhiteSpace(PersonName.LastName) && !string.IsNullOrWhiteSpace(Father.PersonName.LastName))
                PersonName.LastName = Father.PersonName.LastName;

            if (string.IsNullOrWhiteSpace(PersonName.Patronymic) && !string.IsNullOrWhiteSpace(Father.PersonName.FirstName))
                PersonName.Patronymic = Father.PersonName.FirstName + "ович";
        }

        public override string ToString()
        {
            if (Height.HasValue)
                return $"{PersonName} {Height.Value}";
            else
                return $"{PersonName}";
        }
    }
}
