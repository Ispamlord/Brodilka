using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2222
{
    public class Pole
    {
        static public bool LEvel{ set; get; }
        public int Hight { get; }
        public int Weight { get; }
        public int maxCreep { get; }
        public Pole(int hight, int weight, int MaxCreep)
        {
            Hight = hight;
            Weight = weight;
            maxCreep = MaxCreep;
        }
        public void ProverkaLevel()
        {
            
            if (Enemy.cout == 0)
            {
                

            }

        }
        

    }
}
