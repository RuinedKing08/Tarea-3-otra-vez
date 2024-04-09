using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    public class Enemy
    {
        public int enemyHP;
        public int dmg;
        public int id;

        public Enemy(int startHP, int dmg, int id)
        {
            this.enemyHP = startHP;
            this.dmg = dmg;
            this.id = id;
        }

        public void EnemyTakeDamage(int damage)
        {
            enemyHP -= damage;
            if (enemyHP < 0)
            {
                enemyHP = 0;
            }
        }

        public virtual int EnemyGetDmg()
        {
            return dmg;
        }

        public bool IsAlive()
        {
            return enemyHP > 0;
        }
    }
}
