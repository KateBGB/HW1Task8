Console.Write("Введите число:() ");
int n = int.Parse(Console.ReadLine());
int a = 1;
if(n>0)
{
    while(a<=n)
    {
        Console.WriteLine($"{a}");
        a = a+1;
    }
}
else
{
    while(a>=n)
    Console.WriteLine($"{a}");
    a = a-1;
}