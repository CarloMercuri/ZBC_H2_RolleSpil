using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Abilities
{
    public class ThrowFrostNova : ICharacterPassiveAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Throwing Frost Nova!");
        }
    }
}
