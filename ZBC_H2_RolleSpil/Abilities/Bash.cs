using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Abilities
{
    public class Bash : ICharacterPassiveAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Bashing!");
        }
    }
}
