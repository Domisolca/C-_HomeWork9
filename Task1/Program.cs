int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumber(int a)
{
    if (a == 1)
        Console.Write(a);
    else
    { 
        Console.Write(a + ", ");
        NaturalNumber(a - 1);
    }
}

int number = ReadInt("Задайте число: ");

if(number < 1)
{
    Console.WriteLine("Число должно быть больше 0!");
    return;
}

NaturalNumber(number);

