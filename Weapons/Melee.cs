using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Weapons
{
     public class Melee : Weapon
    {
        public override string Name { get; set; }
        public override string Country { get; set; }
        public override string SerialNo { get; set; }
        public override byte Damage { get; set; }
        public byte Health { get; set; }

        public override void Sound(string location)
        {
            SoundPlayer meleeSound = new SoundPlayer(location);
            meleeSound.Play();
        }
    }
}
