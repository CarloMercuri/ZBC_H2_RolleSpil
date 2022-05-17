using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Abilities
{
    public class Teleport : ICharacterLocalizedAbility
    {
        public void UseAbility(int x, int y)
        {
            Console.WriteLine($"Teleporting to: {x}x, {y}y!");
        }
    }
}
