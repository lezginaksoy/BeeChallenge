using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeChallenge
{
    public abstract class BeeBase
    {
        public double Health = 100.00;
        public bool Dead { get; set; }

        public abstract bool IsDead();
        public void Damage(int attack)
        {
            if (attack > 0 && attack < 100)
            {
                var perVal = (attack / Health) * 100;

                Health -= perVal;
            }
        }
    }
}
