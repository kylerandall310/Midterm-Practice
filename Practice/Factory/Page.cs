using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public abstract class Page
    {
        private string content;
        
        public virtual string Content
        {
            get { return this.content; }
            set { this.content = value;  }
        }

        public override string ToString()
        {
            return this.content;
        }
    }
}
