using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{


    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Adventure Quest!");

            Console.WriteLine("What do you call yourself?");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
                Console.WriteLine("You can't remember your name?");
            else
                Console.WriteLine("You awaken in your room. A loud knocking at the door is what woke you up.");
                Console.WriteLine("So your name is " + currentPlayer.name);
            Console.ReadKey();
        }
    }



}