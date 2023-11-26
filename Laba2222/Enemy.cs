using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba2222
{
    public class Enemy
    {
        public int damage { get; }
        public int HP { get; }
        public int Range { get; }
        public int speedX { set; get; }
        public int speedY { set; get; }
        public int X { set; get; }
        public int Y { set; get; }
        static int cout { get;}
        public Enemy();
        
        public Enemy(int dmg, int hp, int range, int speedx, int speedy, int x, int y)
        {
            damage=dmg;
            HP=hp;
            Range=range;
            speedX=speedx;
            speedY=speedy;
            X=x;
            Y=y;
            cout++;
        }
        public void Dead()
        {
            if (HP <= 0)
            {
                cout--;
            }
        }

    }
    
    

    public class warrior:Enemy
    {
        
    }
    public class archer
    {

    }
}
