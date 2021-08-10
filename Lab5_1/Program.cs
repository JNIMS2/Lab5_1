using System;
using System.Collections.Generic;
namespace Lab5_1
{
    class GameCharacter
    {//Jeff said we could make them public//

        public string Name;
        public int Strength;
        public int Intelligence;
     
        public GameCharacter(string _Name, int _Strength, int _Intelligence)
        {
            Name = _Name;
            Strength = _Strength;
            Intelligence = _Intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}\n");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy;

        public MagicUsingCharacter(string _Name, int _Strength, int _Intelligence, int _MagicalEnergy) : base(_Name, _Strength, _Intelligence)
        {

            MagicalEnergy = _MagicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy: {MagicalEnergy}\n");
        }
    }
    class Warrior : GameCharacter
    {
        public string WeaponType;

        public Warrior(string _Name, int _Strength, int _Intelligence, string _WeaponType) : base(_Name, _Strength, _Intelligence)
        {
            WeaponType = _WeaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Weapon Type: {WeaponType}\n");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber;

        public Wizard(string _Name, int _Strength, int _Intelligence, int _MagicalEnergy, int _SpellNumber) : base(_Name, _Strength, _Intelligence, _MagicalEnergy)
        {
            SpellNumber = _SpellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy: {MagicalEnergy}, Spell Number: {SpellNumber}\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //make a list of Game Chars and call it gameCharacters

            GameCharacter cg1 = new GameCharacter("Paul the Dwarf", 15, 19);
            //cg1.Name = "Paul";//idk why this way doesn't work. Is it because i have a constructor for it?
            //so, it makes me do it the way on line 81....right?
            //cg1.Strength = 15;
            //cg1.Intelligence = 19;
            //cg1.Play();

            GameCharacter cg2 = new GameCharacter("Stephanie the human", 16, 21);
            //cg2.Play();

            GameCharacter cg3 = new GameCharacter("Alberto the Barbarian", 18, 13);
            //Console.Write($"\n{cg3.Play()}"); voids can't convert to objects, got it...
           // cg3.Play();

            List < GameCharacter >  MainGameCharList = new List<GameCharacter>();
            MainGameCharList.Add(cg1);
            MainGameCharList.Add(cg2);
            MainGameCharList.Add(cg3);

            //then add 2 warriors

            Warrior war1 = new Warrior("Olaf the Warrior", 21, 18, "Sword");
            //war1.Play();

            Warrior war2 = new Warrior("Tringali the Warrior", 23, 16, "Ball and Chain");
            //war2.Play();

            MainGameCharList.Add(war1);
            MainGameCharList.Add(war2);


            //and add 3 wizards

            Wizard wiz1 = new Wizard("Petra the Wizard", 16, 23, 18, 17);
            //wiz1.Play();

            Wizard wiz2 = new Wizard("Mousafir the Wizard", 14, 21, 19, 18);
            //wiz2.Play();

            Wizard wiz3 = new Wizard("Neem the Wizard", 12, 22, 21, 15);
            //wiz3.Play();

            MainGameCharList.Add(wiz1);
            MainGameCharList.Add(wiz2);
            MainGameCharList.Add(wiz3);

            Console.WriteLine("Welcome to World of Dev.Buildcraft!\n");

            //do a loop to invoke play method for all objects in that array.
            foreach(GameCharacter  chrctr in MainGameCharList)
            {
                chrctr.Play();
            }
        }
    }
}