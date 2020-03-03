using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Factory
{
    public class Document
    {
        List<Page> aListOfPages;

        public void Add(Page p)
        {
            this.aListOfPages.Add(p);
        }
    }
}
