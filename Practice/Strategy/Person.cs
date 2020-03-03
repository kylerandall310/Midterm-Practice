using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public OutputInterface Output {get; set;}
        private Person()
        {

        }

        public Person(string N, int H, int A, string O)
        {
            this.Name = N;
            this.Height = H;
            this.Age = A;
            this.Occupation = O;
            this.SetOutput(new ConsoleView());
        }
        
        public void SetOutput(OutputInterface o)
        {
            this.Output = o;
        }

        public void Print()
        {
            Console.WriteLine(this.Output.View(this));
        }

    }
}
