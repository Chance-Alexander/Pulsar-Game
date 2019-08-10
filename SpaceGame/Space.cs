using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Space
    {
        public static void Main()
        {
            Planets.Planet = new Planets();
            Menus Menu1 = new Menus();
            Console.Write("Welcome to Space Game, hit the 'Enter key to continue");
            Menus.MenuOption();
            string choice = Console.ReadLine();
            int option;
            while (!int.TryParse(choice, out option))
            {
                Menus.MenuOption();
                choice = Console.ReadLine();

            }
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 2:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 3:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 4:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 5:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 6:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 7:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 8:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 9:
                    Console.Clear();
                    Planets.Planet1();
                    break;
                case 10:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
