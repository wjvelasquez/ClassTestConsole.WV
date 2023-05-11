using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest.App.Extensions;
static internal class PersonExtensionMethods
{
    public static Person Upper(this Person person)
    {
        person.Name = person.Name.ToUpper();
        person.Lastname = person.Lastname.ToUpper();

        return person;
    }
}
