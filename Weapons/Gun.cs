using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Weapons
{
    public class Gun : Weapon,IGun
    {
        public override string Name { get; set; }
        public override string Country { get; set; }
        public override string SerialNo { get; set; }
        public override byte Damage { get; set; }
        public byte Ammo { get; set; }

        public override void Sound(string location)
        {
            SoundPlayer gunSound = new SoundPlayer(location);
            gunSound.Play();
        }

        public void Reload(string location)
        {
            SoundPlayer reloadSound = new SoundPlayer(location);
            reloadSound.Play();
        }
    }
}
