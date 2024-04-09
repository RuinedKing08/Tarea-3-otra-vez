using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    public class RangeEnemy : Enemy
    {
        private int ammo;

        public RangeEnemy(int enemyHP, int rangedmg, int ammo, int id) : base(enemyHP, rangedmg, id)
        {
            this.ammo = ammo;
        }

        public override int EnemyGetDmg()
        {
            if (this.ammo > 0)
            {
                this.ammo--;
                return dmg;
            }
            else
            {
                Console.WriteLine("Ranged enemy skips turn");
                return 0;
            }
        }
    }
}
