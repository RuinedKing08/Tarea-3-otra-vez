using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    public class Player
    {
        private int hp;
        private int dmg;

        public Player(int hp, int dmg)
        {
            this.hp = hp;
            this.dmg = dmg;
        }

        public static Player CreatePlayer()
        {
            int hp = 0;
            int dmg = 0;

            do
            {
                Console.WriteLine("Insert player HP value (must not excede 100):");
                hp = int.Parse(Console.ReadLine());

                if (hp > 100)
                {
                    Console.WriteLine("Player HP may not excede 100");
                    continue;
                }

                Console.WriteLine("Insert player Damage value (must not excede 100):");
                dmg = int.Parse(Console.ReadLine());

                if (dmg > 100)
                {
                    Console.WriteLine("Player Damage may not excede 100");
                    continue;
                }

            } while (hp > 100 && dmg > 100);

            return new Player(hp, dmg);
        }

        public int GetHP()
        {
            return hp;
        }

        public int GetDmg()
        {
            return dmg;
        }

        public void TakeDamage(int dmgtaken)
        {
            hp -= dmgtaken;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}
