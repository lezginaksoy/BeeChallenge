using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeChallenge
{
    public class DroneBee : BeeBase
    {
        public override bool IsDead()
        {       
            if (Health < 50)
               return true;

            return false;
        }
    }
}
