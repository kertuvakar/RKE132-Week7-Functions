

Console.WriteLine("Are you coming or going? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello()//kasutan seda funtsiooni
}
else (userChoice == "out")
{
    PrintGoodBye()
}



static void PrintHello() //funktsioon ehk meetod, defineerin meetodi
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator!");
}