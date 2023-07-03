public class Menu 
{
    private List<Goal> _goals = new List<Goal>();
    int score = 0;

public void Display()
{
    while (true)
    {
        Console.WriteLine("1: Create a new goal\n2: List goals\n3: Save Goals\n4: Load Goals\n5: Record Event");
        string response = Console.ReadLine();

        if (response == "1")
        {
            Console.WriteLine("1: Simple Goal\n2: Eternal Goal\n3: Checklist Goal");
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
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.DisplayToFile());
                }
            }
        }

        if (response == "4")
        {
            Console.WriteLine("What is the name of the file?");
            string filename = Console.ReadLine();
            
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                string[] cparts = parts[1].Split(",");

                if (parts[0] == "Checklist Goal")
                {
                    string _name = cparts[0];
                    string _description = cparts[1];
                    int _points = int.Parse(cparts[2]);
                    int _bonusPoints = int.Parse(cparts[3]);
                    int _amountNeeded = int.Parse(cparts[4]);
                    int _timesCompleted = int.Parse(cparts[5]);
                    bool _isFinished = bool.Parse(cparts[6]);

                    Checklist checklist = new Checklist(_name, _points, _isFinished, _description, _timesCompleted, _amountNeeded, _bonusPoints);
                    _goals.Add(checklist);
                }
                if (parts[0] == "Simple Goal")
                {
                    string _name = cparts[0];
                    string _description = cparts[1];
                    int _points = int.Parse(cparts[2]);
                    bool _isFinished = bool.Parse(cparts[3]);

                    ShortTerm simple = new ShortTerm(_name, _points, _isFinished, _description);
                    _goals.Add(simple);
                }
                if (parts[0] == "Eternal Goal")
                {
                    string _name = cparts[0];
                    string _description = cparts[1];
                    int _points = int.Parse(cparts[2]);

                    Eternal eternal = new Eternal(_name, _points, _description);
                    _goals.Add(eternal);
                }
            }
        }
        if (response == "5")
        {
            int counter = 0;
            Console.WriteLine("The goals are: \n");
            foreach (Goal goal in _goals)
            {
                Console.Write($"{counter + 1}: " );
                goal.Display();
                counter += 1;
            }
            Console.WriteLine("Which goal would you like to mark?");
            int answer = int.Parse(Console.ReadLine());

            score += _goals[answer - 1].GivePoints();
            Console.WriteLine($"You received {_goals[answer - 1].GivePoints()} points!\n");
            
            _goals[answer - 1 ].Complete();
            Console.WriteLine($"You have {score} points");
        }
    }
}

}