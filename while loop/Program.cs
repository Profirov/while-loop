using System;

string favoriteBook = Console.ReadLine();


int counter = 0;
bool isBookFound = false;
string nextBook = Console.ReadLine();

while (nextBook != "No More Books")
{
    if (nextBook == favoriteBook)
    {
      isBookFound = true;

        break;
    }

    counter++;
    nextBook = Console.ReadLine();
    

}
if (!isBookFound)
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {counter} books.");
    
}
else
{
    
    Console.WriteLine($"You checked {counter} books and found it.");
}