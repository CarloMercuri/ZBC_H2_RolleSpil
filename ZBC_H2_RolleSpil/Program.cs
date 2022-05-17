using System;
using ZBC_H2_RolleSpil.Characters;

namespace ZBC_H2_RolleSpil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterControl control = new CharacterControl();
            Console.WriteLine("Wizard!");
            Console.WriteLine("");
            Console.WriteLine("");
            control.TestWizard();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            Console.WriteLine("Knight!");
            Console.WriteLine("");
            Console.WriteLine("");
            control.TestKnight();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            Console.WriteLine("Barbarian!");
            Console.WriteLine("");
            Console.WriteLine("");
            control.TestBarbarian();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            Console.WriteLine("Witch!");
            Console.WriteLine("");
            Console.WriteLine("");
            control.TestWitch();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();


            Console.ReadKey();
            
        }
    }
}
