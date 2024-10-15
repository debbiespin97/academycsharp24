// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 0;

#region Codice di esempio
if (a == 0)
#endregion

#if DEBUG
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("Siamo in debug!");
        Console.WriteLine(i);
    }
#endif

#if RELEASE
   for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine("Siamo in Release!");
        Console.WriteLine(i);
    }
#endif


