using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        //declarations
        static int health;
        static int lives;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals:");
            Console.WriteLine("-------------");
            Console.WriteLine(" ");

            //initializations
            health = 100;
            lives = 3;

            //sample gameplay
            ShowHud();
            TakeDamage(10);
            ShowHud();
            TakeDamage(50);
            ShowHud();
            TakeDamage(50);
            ShowHud();



            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("You took " + damage + " damage");
            health = health - damage;

            //range check health 0to100
            if (health < 0)
            {
                Console.WriteLine("YOU DIED");

                lives = lives - 1;

                //lives range check
                if (lives <= 0)
                {
                    Console.WriteLine("GAME OVER");
                }

                //set health to be 0
                health = 0;
            }        
        }

        static void ShowHud()
        {
            Console.WriteLine();

            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);

            Console.WriteLine();
        }
    }
}
