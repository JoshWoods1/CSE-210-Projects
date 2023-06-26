public class Menu 
{
    private List<Goal> _goals = new List<Goal>();


public void Display()
{
    while (true)
    {
        Console.WriteLine("1: Create a new goal\n2: List goals\n3: Save Goals\n 4: Load Goals\n 5: Record Event");
        string response = Console.ReadLine();

        if (response == "1")
        {
            Console.WriteLine("1: Simple Goal\n 2: Eternal Goal\n 3: Checklist Goal");
            string gresponse = Console.ReadLine();
            if (gresponse == "1")
            {
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());

                ShortTerm sgoal = new ShortTerm(name, points, false, description);
                _goals.Add(sgoal);
            }

            if (gresponse == "2")
            {
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());

                Eternal egoal = new Eternal(name, points, description);
                _goals.Add(egoal);
            }

            if (gresponse == "3")
            {
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string description = Console.ReadLine();
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does it need to be completed?");
                int amountNeeded = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for completion?");
                int bonusPoints = int.Parse(Console.ReadLine());

                Checklist cgoal = new Checklist(name, points, false, description, 0, amountNeeded, bonusPoints);
                _goals.Add(cgoal);
            }
        }

        if (response == "2")
        {
            foreach (Goal goal in _goals)
            {
                goal.Display();
            }
        }

        if (response == "3")
        {
            Console.WriteLine("What is the filename for the goal file?");
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                for
            }
        }
    }
}
}