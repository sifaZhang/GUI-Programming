using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SimpleClass
    {
        public string Name;
        public int Age;

        public SimpleClass(string aName, int anAge)
        {
            Name = aName;
            Age = anAge;
        }

        public override string ToString()
        {
            return Name + "  (" + Age.ToString() + ")";
        }

        public string Show()
        {
            return ("Name:" + Name + "  Age:"
            + Age.ToString());
        }

    }
}
