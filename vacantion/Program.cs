

double tripCost = double.Parse(Console.ReadLine());
double avalibleMoney = double.Parse(Console.ReadLine());

int totalDays = 0;
int spendingCounter = 0;

while (avalibleMoney < tripCost && spendingCounter < 5)
{ 
  string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());

    if (action == "save")
    {
        avalibleMoney += amount;
        spendingCounter = 0;
    }
    else if (action == "spend")
    { 
     avalibleMoney -= amount;

        if (avalibleMoney < 0) 
        {
            avalibleMoney = 0;
        }
        spendingCounter++;
    }
    totalDays++;
}
if (spendingCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(totalDays);
}
else
{
    Console.WriteLine($"You saved the money for {totalDays} days.");
}
