using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*********************** Singleton Pattern ***********************/


            /********************** Decorator Pattern *********************/

            Vehicle aCar = new Car();
            aCar = new TurboCharger(aCar);
            aCar = new CorinthianLeatherSeats(aCar);
            aCar = new ColdAirIntake(aCar);
            Console.WriteLine(aCar.ToString());


            /*********************** Factory Pattern ***********************/


            /*********************** Adapter Pattern ***********************/
            // create a playa
            Player playa = Player.Instance;

            // give the player a sword
            Sword theSword = new Sword(10, 19);
            playa.Weapon = theSword;

            // give the player a space blaster
            Blaster pewpew = new Blaster(10, 10, 1);
            playa.Weapon = new SpaceBlasterAdapter(pewpew);

            //adding comments to make burke happy.
            Console.WriteLine("Player Weapon Damage: "+playa.Weapon.Damage);



            /*********************** Strategy Pattern ***********************/
            Person Kyle = new Person("Kyle Randall", 72, 22, "Hentai Analyst");
            Kyle.Print();
            Kyle.SetOutput(new WebView());
            Kyle.Print();


            /*******************  Freeze Display ***********************/
            Console.Read();
        }

    }
}
