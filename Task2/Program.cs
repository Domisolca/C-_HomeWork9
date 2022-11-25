int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNumber(int a, int b)
{
    if (a == b)
        return b;
    else if (b > a)
    {
        return b + SumNaturalNumber(a, b - 1);
    }
    else
    {
        return a + SumNaturalNumber(a - 1, b);
    }
}

int numberM = ReadInt("Задайте число M: ");
int numberN = ReadInt("Задайте число N: ");

Console.WriteLine(SumNaturalNumber(numberM, numberN));