using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2222
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game();

        }
        static void Game()
        {
            Random rnd = new Random();
            Pole first = new Pole(3200, 3200, 8);
            for(int i = 0; i < first.maxCreep; i++)
            {
                int spawnX = rnd.Next(0, first.Hight);
                int spawnY = rnd.Next(0, first.Weight);
                Enemy voin = new warrior(5,100,0,3,3,spawnX,spawnY);
            }
        }
    }
}
