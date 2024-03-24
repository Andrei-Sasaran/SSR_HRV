class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti numarul de termeni doriti sa fie calculati: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;
        if(n <= 0)
        {
            Console.WriteLine("Numarul de termeni nu este posibil");
        }
        else if( n== 1)
        {
            Console.Write("Primul termen Fibonacci este: ");
            Console.Write(a);
        }
        else
        {
            Console.WriteLine("Primii " + n + " termeni Fibonacci sunt:");
            Console.Write(a + " " + b + " ");
            for(int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
            }
        }
    }
}