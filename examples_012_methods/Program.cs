// Type 1 ------- Ничего не принимают и ничего не возвращают
void Method1()                      //funkcia
{
    Console.WriteLine("Author...");
}

Method1();                          // pravilnii vyzov funkcii
//Method1;                          // nepravilnii vyzov funkcii


// Type 2 -------- Что-то принимают, ничего не возвращают. Void methods
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


// Type 3 -------- Ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Type 3 -------- Что-то принимают и что-то возвращают

string Method4(int count, string text)  // esli pereimenovat peremennuiu cerez rename symbol, to ona pereimenuetsia vo vseom methode
{
    int i = 0;
    string result = String.Empty;    //stejne jako == string result = ""; mame vložit neco do nej, dokonce i neco empty

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);