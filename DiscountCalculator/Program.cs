

//tavaliselt, kui funktsioon lõpetab oma töö, kustutatakse muutujad ja kood vahemälust
//on vaja funktsiooni tulemust salvestada ja hiljem kasutada

// <10 - 1%
//total >=10 && total <20 - 5%
//total >= 20 - 10%

//kasutaja ütleb, kui palju tal arve kokku läks, meie arvutame allahindluse

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());



double discount = CalculateDiscount(userInput);//double andmetüüpi muutuja. sellesse salvestatakse üks if luubi return muutuja

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput,discount);

Console.WriteLine($"You updated total is: {newTotal}%");
static double CalculateDiscount(int total)
//kui if on oma töö lõpetanud, siis vahemälusse on salvestunud mingi väärtus
{
    if(total < 10)//kui total on väiksem kui 10, siis mälusse salvestatakse andmetüüp double ja väärtus 1
    {  
        return 1; 
    }
    else if (total >= 10 && total < 20)//kui total on 10 ja 20 vahel, siis mälusse salvestatakse andmetüüp double ja väärtus 5
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
    //kuna tegemist on plokkidega, neid ei panda käima ühel ja samal ajal
    //seetõttu võib kasutada samu parameetreid nagu nt total
{
    double result = total - (total * discount) / 100;
    return result;
}