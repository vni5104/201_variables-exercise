namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Vicky";
            string heroLastName = "Ni";
            string heroFullName;

            string villainTitle = "Rose Garden Witch";
            string minionTitle = "Familiar";
            string villainName;
            string minion1Name;
            string minion2Name;

            //Begin Code Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose " +
                "name is: " + heroFullName);

            villainName = "Gertrud";
            minion1Name = "Anthony";
            minion2Name = "Adelbert";

            Console.WriteLine(heroFullName + "'s enemy is: " + villainName + " the " + villainTitle);
            Console.WriteLine(villainName + "'s minions are: " + minion1Name + " the " + minionTitle +
                " and " + minion2Name + " the " + minionTitle);
        }
    }
}
