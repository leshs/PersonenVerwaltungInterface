using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenVerwaltungInterface
{
    interface IPersonListener
    {
        void NotifyChange(List<Person> personen);
    }
}
