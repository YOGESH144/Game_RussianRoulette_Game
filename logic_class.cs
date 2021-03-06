using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_form
{
    public class logic_class
    {
        public int load_position;
        public int spin_position;
        public int head_shot;
        public int chances = 1;

      public int shoot()
        {
            if (load_position == spin_position)
            {
                return 1;
            }
            else if (spin_position == 6)
            {
                spin_position = 1;
                return 0;
            }
            else
            {
                spin_position++;
                return 0;
            }
        }


    }
}
