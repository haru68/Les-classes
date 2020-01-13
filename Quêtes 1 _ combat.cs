using System;

namespace Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            character Yves = new character();
            Yves.Name = "Yves";
            character Wang = new character();
            Wang.Name = "Wang";

            Random RandomPoint = new Random();

            Yves.HealthPoints = RandomPoint.Next(8, 12);
            Yves.Power = RandomPoint.Next(5, 15);
            Yves.Defense = RandomPoint.Next(5, 15);

            Wang.HealthPoints = RandomPoint.Next(8, 12);
            Wang.Power = RandomPoint.Next(5, 15);
            Wang.Defense = RandomPoint.Next(5, 15);


            while (Yves.IsAlive() && Wang.IsAlive())
            {
                Yves.attack(Wang);
                Wang.attack(Yves);   
            }

            Yves.winner();
            Wang.winner();



           
            


        }

       
    }

    public class character
    {
        public string Name;
        public int HealthPoints;
        public int Power;
        public int Defense;

        public bool IsAlive()
        {
            if (HealthPoints>0)
            {
                return true; 
            }
            else
            {
                Console.WriteLine(Name + " has died. ");
                return false;
            }
        }

        public void attack(character ennemy)
        {
            int damages = Power - ennemy.Defense;

            if (damages > 0)
            {
                ennemy.HealthPoints = ennemy.HealthPoints - damages;
                Console.WriteLine(ennemy.Name + " has lost " + damages + " points of HP.");
                Console.WriteLine(ennemy.Name + " has " + HealthPoints + "HP left.");
            }
            else
            {
                Console.WriteLine("Attack failed");
            }
        }

        public void winner()
        {
            if (IsAlive())
            {
                Console.WriteLine(Name + " is the winner!");
                Console.WriteLine("Is another courageous warrior wants to join the battle?");
            }
        }
    }
}
