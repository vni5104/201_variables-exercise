namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **** Variables ****
            string heroFirstName = "Vicky";
            string heroLastName = "Ni";
            string heroFullName;

            //inspired by the witch Getrud from Puella Magi Madoka Magica
            string villainTitle = "Rose Garden Witch";
            string minionTitle = "Familiar";
            string villainName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            //**** Begin Code Instructions ****
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose " +
                "name is: " + heroFullName);

            villainName = "Gertrud";
            minion1Name = "Anthony";
            minion2Name = "Adelbert";

            Console.WriteLine(heroFullName + "'s enemy is: " + villainName + " the " + villainTitle);
            Console.WriteLine(villainName + "'s minions are: " + minion1Name + " the " + minionTitle +
                " and " + minion2Name + " the " + minionTitle);
            Console.WriteLine(""); //new line for printing on console

            Console.WriteLine("The fighers enter the labyrinth!");
            Console.WriteLine("Hero's Health: " + heroHealth);
            Console.WriteLine("Boss's Health: " + bossHealth);
            Console.WriteLine("Minion 1's Health: " + minion1Health);
            Console.WriteLine("Minion 2's Health: " + minion2Health);
            Console.WriteLine("");


            //**** Time to fight! ****

            //Boss attacks first
            Console.WriteLine("Time to fight!");
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //updates variables
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero's turn
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            //update variables
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //The minions have been defeated
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round buff
            Console.WriteLine("");
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " eats an apple to restore health");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");


            //Round 2 of fight
            Console.WriteLine("");
            Console.WriteLine("The remaining fighters continue to fight!");
            Console.WriteLine("Hero's Health: " + heroHealth);
            Console.WriteLine("Boss's Health: " + bossHealth);

            //Boss attacks first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero's turn
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " +
                heroStrength + " damage!");
            bossHealth -= heroStrength;
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");


            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");
        }
    }
}
