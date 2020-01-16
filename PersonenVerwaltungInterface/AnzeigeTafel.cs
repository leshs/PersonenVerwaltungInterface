using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltungInterface
{
    class AnzeigeTafel : IPersonListener
    {
        public void NotifyChange(List<Person> personen)
        {
            PersonenAnzeigen(personen);
        }

        public void PersonenAnzeigen(List<Person> personenListe)
        {
            foreach (Person person in personenListe)
            {
                Console.WriteLine(person.getInfo());
            }
        }
    }
}
