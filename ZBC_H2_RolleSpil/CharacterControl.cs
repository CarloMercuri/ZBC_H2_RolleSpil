using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_RolleSpil.Abilities;
using ZBC_H2_RolleSpil.Characters;

namespace ZBC_H2_RolleSpil
{
    public class CharacterControl
    {
        public GameCharacter CreateWizard()
        {
            GameCharacter character = new Wizard();
            character.AddAbility(new Heal());
            character.AddAbility(new Fight());
            character.AddAbility(new Teleport());
            character.AddAbility(new ThrowMagicMissile());
            character.AddAbility(new ThrowFrostNova());


            return character;
            
        }

        public GameCharacter CreateBarbarian()
        {
            GameCharacter character = new Barbarian();
            character.AddAbility(new Heal());
            character.AddAbility(new Fight());
            character.AddAbility(new Bash());
            character.AddAbility(new Cleave());
            character.AddAbility(new Slash());


            return character;
        }

        public GameCharacter CreateKnight()
        {
            GameCharacter character = new Knight();
            character.AddAbility(new Heal());
            character.AddAbility(new Fight());
            character.AddAbility(new Bash());
            character.AddAbility(new Cleave());
            character.AddAbility(new RaiseShield());
            character.AddAbility(new Slash());
            character.AddAbility(new ShieldGlare());


            return character;
        }

        public GameCharacter CreateWitch()
        {
            GameCharacter character = new Witch();
            character.AddAbility(new Heal());
            character.AddAbility(new Fight());
            character.AddAbility(new RaiseShield());
            character.AddAbility(new ShieldGlare());
            character.AddAbility(new Teleport());


            return character;
        }

        public void TestWizard()
        {
            GameCharacter wizard = CreateWizard();
            wizard.UseAbilities();
        }

        public void TestBarbarian()
        {
            GameCharacter barbarian = CreateBarbarian();
            barbarian.UseAbilities();
        }

        public void TestWitch()
        {
            GameCharacter witch = CreateWitch();
            witch.UseAbilities();
        }

        public void TestKnight()
        {
            GameCharacter knight = CreateKnight();
            knight.UseAbilities();
        }
    }
}
