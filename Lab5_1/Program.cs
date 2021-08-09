using System;

namespace Lab5_1
{
    class GameCharacter
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        //didn't make constructors yet.
        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}.\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEngergy;
    }
    class Warrior : GameCharacter
    {
        public string WeaponType;
    }

    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(  "test");
        }
    }
}
