
Console.WriteLine("Введите число символом которое мы должны проверить на полидром:");
int x = int.Parse(Console.ReadLine());
char[] mas = new char[x];

Console.WriteLine("Введите "+ x + " символа:");
for (int i = 0; i < x; i++)
{
    mas[i] = Console.ReadKey().KeyChar;
    Console.Write(" "); 
}


string str = new string(mas).Replace(" ", "");


bool pal = true;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - 1 - i])
    {
        pal = false;
        break;
    }
}


if (pal)
{
    Console.WriteLine("\nЭто палиндром.");
}
else
{
    Console.WriteLine("\nЭто не палиндром.");
}