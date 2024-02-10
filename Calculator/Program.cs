
//Lihtne kalkulaator
//kui kood lõpetab tööd, siis kõik muutujad kustutatakse vahemälust
char userOperator = Char.Parse(Console.ReadLine());//kasutaja sisestab operaatori

Console.WriteLine("Enter a");//kirjuta esimene arv
int firstNum = Int32.Parse( Console.ReadLine());

Console.WriteLine("Enter b");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{ 
    case '+':
        Addition(firstNum, secondNum);//firstNum on a ja secondNum on b
        break;
    case '-':
        Substraction(firstNum, secondNum);//firstNum on a ja secondNum on b
        break;
    default: Console.WriteLine("Invalid operator");
        break;

}

static void Addition (int a, int b)//anname funktsioonile kindlat andmetüüpi muutujad
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}