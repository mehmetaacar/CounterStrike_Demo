using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Weapons
{
    public abstract class Weapon
    {
        public abstract string Name { get; set; }
        public abstract string Country { get; set; }

        public abstract string SerialNo { get; set; }

        public abstract byte Damage { get; set; }

        public abstract void Sound(string location);

        

        
    }
}
