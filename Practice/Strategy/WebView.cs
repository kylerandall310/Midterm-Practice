using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class WebView : OutputInterface
    {
        public string View(Person p)
        {
            return "<b>Name:</b> " + p.Name + " <b>Occupation:</b> " + p.Occupation;
        }
    }
}
