using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ConsoleView : OutputInterface
    {
        public string View(Person p)
        {
            return "Name: " + p.Name + " Occupation: "+p.Occupation;
        }
    }
}
