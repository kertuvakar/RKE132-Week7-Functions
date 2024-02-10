
//tahaks võtta kasutaja sõna asendada läbivad suurtähed ja printida seda sõna viis korda

Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyword(userInput);//userInput-argument
static void PrintAnyword(string anyString) //funktsioon ehk meetod, defineerin meetodi
    //annan funktsioonile ühte kindlat tüüpi (string) parameetri anyString

{
    anyString = anyString.ToUpper();
    if (int i = 0; i < 5; i++)
    {
        Console.WriteLine();
    }
}
