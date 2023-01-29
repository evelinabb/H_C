string MethodForFor (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++) //inicialiyzcia scetcika; proverka uslovia; inkrement
    {
        result +=text;
    }
    return result;
}
string res = MethodForFor(10, "z");
Console.WriteLine(res);