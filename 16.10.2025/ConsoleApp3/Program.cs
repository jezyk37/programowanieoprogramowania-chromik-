int a = 4;
int b;

MojaMetoda(a, out b);

void MojaMetoda(int a, out int b)
{
    b = 10;
    a = b + 6;
}

a++;
b++;

Console.WriteLine(a);
Console.WriteLine(b);