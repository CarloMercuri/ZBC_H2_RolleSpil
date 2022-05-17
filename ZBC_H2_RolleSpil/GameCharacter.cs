using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Interfaces;

namespace ZBC_H2_RolleSpil
{
    public abstract class GameCharacter
    {
        List<ICharacterAbility> Abilities = new List<ICharacterAbility>();

        public void Die()
        {
            Console.WriteLine("I'm dying!");
        }

        public void UseAbilities()
        {
            foreach (ICharacterAbility ability in Abilities)
            {
                if (ability is ICharacterLocalizedAbility)
                {
                    ((ICharacterLocalizedAbility)ability).UseAbility(5, 2);
                }
                else if (ability is ICharacterPassiveAbility)
                {
                    ((ICharacterPassiveAbility)ability).UseAbility();
                }
            }
        }

        public void AddAbility(ICharacterAbility ability)
        {
            Abilities.Add(ability);
        }
    }
}
