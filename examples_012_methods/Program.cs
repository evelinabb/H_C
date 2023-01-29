// Type 1
void Method1()                      //funkcia
{
    Console.WriteLine("Author...");
}

Method1();                          // pravilnii vyzov funkcii
//Method1;                          // nepravilnii vyzov funkcii


// Type 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text soobschenia");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Text soobschenia", 4); //4 - skoliko raz hotim uvedit soobshenie
// Method21(msg: "Text soobschenia", count: 4);         //ili tak
// Method21(count: 4,msg: "Text soobschenia");          //ili tak

