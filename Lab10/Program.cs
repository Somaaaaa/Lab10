using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Labor10
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Player testPlayer = new Player("Teszt", Position.center);
            //Console.WriteLine(testPlayer);

            Player[] playerPool = new Player[50];
            playerPool = RandomPlayers(50);
            Team team = new Team();

            Console.WriteLine("Elérhető Játékosok:");

            for (int i = 0; i < playerPool.Length; i++)
            {
                Console.WriteLine("\t" + i + " : " + playerPool[i]);
            }

            Console.WriteLine("\nVálaszd ki a kívánt játékost a sorszáma megadásával!");
            int input = int.Parse(Console.ReadLine());

            while (input != -1)
            {
                team.Include(playerPool[input]);
                input = int.Parse(Console.ReadLine());
            }


            Console.ReadLine();
        }

        static Player[] RandomPlayers(int numOfPlayers)
        {
            Player[] result = new Player[numOfPlayers];
            string name = "";
            int posInt;

            for (int i = 0; i < result.Length; i++)
            {
                name = "Player " + rnd.Next(1, 100).ToString();
                posInt = rnd.Next(0, 4);
                result[i] = new Player(name, (Position)posInt);
            }

            return result;
        }
    }
}
