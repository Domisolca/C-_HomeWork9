int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FuncAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else
    {
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
}

int numberM = ReadInt("Задайте неотрицательное число m: ");
int numberN = ReadInt("Задайте неотрицательное число n: ");

if(numberM < 0 || numberN < 0)
{
    Console.WriteLine("m и n должны быть неотрицательными!");
    return;
}

Console.WriteLine(FuncAkkerman(numberM, numberN));