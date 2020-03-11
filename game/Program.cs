using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior erick = new Warrior("erick", 1000, 120, 40);
            Warrior david = new Warrior("david", 1000, 120, 40);
            Battle.StartFight(erick, david);
            
            Console.ReadLine();
        }
    }
}
