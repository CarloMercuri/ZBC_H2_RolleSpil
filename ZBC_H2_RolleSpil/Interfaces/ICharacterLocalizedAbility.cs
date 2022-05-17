using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_RolleSpil.Interfaces
{
    internal interface ICharacterLocalizedAbility : ICharacterAbility
    {
        void UseAbility(int x, int y);
    }
}
