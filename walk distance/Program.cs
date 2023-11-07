int dailyGoal = 10000;
int totalSteps = 0;

while (true)
{
  string input = Console.ReadLine();
    if (input == "Going home")
    { 
      int stepsHome =int .Parse(Console.ReadLine());
        totalSteps += stepsHome;
        if (totalSteps >= dailyGoal)
        {
            int stepsOver = totalSteps - dailyGoal;
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{stepsOver} steps over the goal!");
        }
        else
        {
             
           int stepsRemain = dailyGoal - totalSteps;
            Console.WriteLine($"{stepsRemain} more steps to reach goal.");
        }
        break;
    }
    int steps = int.Parse( input);
    totalSteps += steps;
    if ( totalSteps >= dailyGoal)
    {
        int stepsOver = totalSteps - dailyGoal;
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{stepsOver} steps over the goal!");

        break;
    }
}