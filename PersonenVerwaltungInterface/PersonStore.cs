using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltungInterface
{
    class PersonStore
    {
        public List<Person> PersonenListe = new List<Person>();
        public List<IPersonListener> ObserverListe = new List<IPersonListener>();

        public void AddPerson(Person person)
        {
            PersonenListe.Add(person);
            PersonListEdited();
        }

        public void RemovePerson(Person person)
        {
            for (int i = 0; i < PersonenListe.Count; i++)
            {
                {
                    if (PersonenListe[i].ID == person.ID)
                    {
                        PersonenListe.RemoveAt(i);
                        break;
                    }
                }
            }
            PersonListEdited();
        }

        public void EditPerson(Person person)
        {
            for (int i = 0; i < PersonenListe.Count; i++)
            {
                {
                    if (PersonenListe[i].ID == person.ID)
                    {
                        PersonenListe[i] = person;
                        break;
                    }
                }
            }
            PersonListEdited();
        }

        public void PersonListEdited()
        {
            foreach(IPersonListener listener in ObserverListe)
            {
                listener.NotifyChange(PersonenListe);
            }
        }
    }
}
