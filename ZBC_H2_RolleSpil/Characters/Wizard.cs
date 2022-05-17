using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil.Characters
{
    internal class Wizard : GameCharacter
    {
        List<ICharacterAbility> Abilities = new List<ICharacterAbility>();
    }
}
