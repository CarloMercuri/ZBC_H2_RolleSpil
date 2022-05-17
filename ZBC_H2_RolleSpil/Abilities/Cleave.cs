using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Abilities
{
    public class Cleave : ICharacterPassiveAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Cleaving!");
        }
    }
}
