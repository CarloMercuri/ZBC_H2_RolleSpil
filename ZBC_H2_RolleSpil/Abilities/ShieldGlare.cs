using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Abilities
{
    public class ShieldGlare : ICharacterPassiveAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Glaring with my shield!");
        }
    }
}
