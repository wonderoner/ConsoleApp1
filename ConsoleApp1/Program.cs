// Задание 1
Console.WriteLine("Введите число: ");
string c = Console.ReadLine();
int a = Convert.ToInt32(c);
int t = 0;

string b = Convert.ToString(a, 2);
Console.WriteLine(b);

foreach (char g in b)
{
    if (g == '1')
    {
        t += 1;
    }
}
Console.WriteLine("Ответ: " + t);



// Задание 2
Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int num = Convert.ToInt32(n);
Persistence(num);
static int Persistence(int num)
{
    if (num <= 9)
        return 0;
    int c = 0;
    while (num >= 10)
    {
        int g = 1;
        while (num > 0)
        {
            g *= num % 10;
            num /= 10;
        }
        num = g;
        c++;
    }
    Console.WriteLine(num);
    return c;
}

// Задание 3
Console.WriteLine("Введите число: ");
string zzz = Console.ReadLine();
int num = Convert.ToInt32(zzz);
Persistee(num);
static int Persistee(int num)
{
    if (num <= 9)
        return 0;

    int c = 0;

    while (num >= 10)
    {
        int g = 1;

        while (num > 0)
        {
            g += num % 10;
            num /= 10;
        }

        num = g;
        c++;
    }
    Console.WriteLine(num);
    return c;

}


