using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Singleton
{

    public sealed class Player
    {
        // Class Variables
        private static readonly Player instance;
        public string Name { get; set; }

        // Gets and Sets
        public static Player Instance
        {
            get
            {
                return instance;
            }
        }

        // Constructors start here
        private Player() { }


        static Player()
        {
            instance = new Player()
            {
                Name = "The One and Only Radcliff"
            };
        }
  


    }
}
