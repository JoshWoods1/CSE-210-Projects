Running run = new Running("Aug 12, 2023", 300, 50);
Cycling cycle = new Cycling("July 29, 2023", 30, 25);
Swimming swim = new Swimming("July 11, 2023", 60, 75);

List<Activity> activities = new List<Activity>();

activities.Add(run);
activities.Add(cycle);
activities.Add(swim);

foreach (Activity activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}