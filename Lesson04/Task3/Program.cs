Console.Write("Введите строку: ");
string str = Console.ReadLine();
string result = GetLettersFromStr(str);
Console.WriteLine(result);
string GetLettersFromStr(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
