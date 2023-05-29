int SummNumber(string a)
{
    int b = Convert.ToInt32(a);
    int result = 0;
    for (int i = 0; i < a.Length; i++)
        {
            result = result + b%10;
            b = (b-(b%10))/10;
        }
    return result;
}
Console.WriteLine("Введите число");
string a = Console.ReadLine();
int res = SummNumber(a);
Console.WriteLine ($"{a} -> {res}");