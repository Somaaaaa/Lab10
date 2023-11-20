using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor10
{
    class Team
    {
        const int MaxPlayers = 6;
        const int MaxKapus = 1;
        const int MaxVedo = 1;
        const int MaxCenter = 2;
        const int MaxTamado = 2;

        Player[] players;
        int numberOfPlayers;
        int numOfKapus, numOfVedo, numOfCenter, numOfTamado;

        public Team()
        {
            players = new Player[MaxPlayers];
        }
        public int NumberOfPlayers { get { return numberOfPlayers; } }

        private bool IsFull()
        {
            return numberOfPlayers >= 6;
        }

        private bool IsIncluded(Player player)
        {
            bool isIncluded = false;
            foreach (Player p in players)
            {
                if (p == player)
                {
                    isIncluded = true;
                }
            }
            return isIncluded;
        }

        private bool IsAvailable(Player player)
        {
            bool isAvailable = true;
            if (player.Position == Position.kapus)
            {
                if (numOfKapus >= MaxKapus)
                {
                    isAvailable = false;
                }
            }
            else if (player.Position == Position.vedo)
            {
                if (numOfVedo >= MaxVedo)
                {
                    isAvailable = false;
                }
            }
            else if (player.Position == Position.center)
            {
                if (numOfCenter >= MaxCenter)
                {
                    isAvailable = false;
                }
            }
            else if (player.Position == Position.tamado)
            {
                if (numOfTamado >= MaxTamado)
                {
                    isAvailable = false;
                }
            }
            return isAvailable;
        }

        public void Include(Player player)
        {
            if (!IsIncluded(player) && IsAvailable(player) && !IsFull())
            {
                this.players[NumberOfPlayers] = player;
                numberOfPlayers++;

                if (player.Position == Position.kapus)
                    numOfKapus++;
                else if (player.Position == Position.vedo)
                    numOfVedo++;
                else if (player.Position == Position.center)
                    numOfCenter++;
                else if (player.Position == Position.tamado)
                    numOfTamado++;

                Console.WriteLine(player + " sikeresen hozzáadva a csapathoz!");
            }
            else
            {
                Console.WriteLine(
                    "Hiba, a játékos nem adható hozzá a csapathoz: " + player);
            }
        }
    }
}
