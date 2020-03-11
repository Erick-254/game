using System;

namespace game
{
    class Battle
    {
        //startfight
        //warrior1warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1,warrior2)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }


        //loop giving each warrior a chance to fight till one dies
       
        //get attack results
        //warriorA, warriorB
        public static string GetAttackResult(Warrior warriorA,Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();
            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health -
                    dmg2WarB;
            }
            else dmg2WarB = 0;
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);
            Console.WriteLine("{0} has {1} health \n",
                warriorB.Name ,warriorA.Health  );
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious \n",
                   warriorB.Name,
                   warriorA.Name);
                return "Game over";
            }
            else return "play again";
        }

        //calculate 1 warrior attack $ block
        //subtract block from attack

        //if there was damage subtract that from health

        //print out info and how much damage
        //provide output on health change
        // and if 0 print message
        //
    }
}
