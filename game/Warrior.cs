using System;

namespace game
{
    class Warrior
    {
        //name health attack maximum block max
        public string Name { get; set; } = "warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;
        //random numbers
        Random rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0,
            double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
        //attack
        //generate random attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        //block
        //generate random block max value
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}