namespace _01_functions;

    internal class Program
{
    static void Main(string[] args)
    {
        Program Program = new Program();
        Program.Run();// er word een niewe program gemaakt en daarna gaat hij het program runnen 
        Program.vraag1();
        Program.vraag2();
        Program.vraag3();
        Program.vraag4();
        Program.vraag5();
        Program.vraag6();
        
    } // het is een function. het return type function is

    internal void Run()
    {
        Console.WriteLine("hoi");
    }
    internal void vraag1()
    {
        Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
        internal void vraag2()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord2 = Console.ReadLine();

        Console.WriteLine(antwoord2);
    }
        internal void vraag3()
    {
        Console.WriteLine("Have you ever tried talking to a animal?");
        string antwoord3 = Console.ReadLine();

        Console.WriteLine(antwoord3);
    }
        internal void vraag4()
    {
        Console.WriteLine("What would you call a male ladybug?");
        string antwoord4 = Console.ReadLine();

        Console.WriteLine(antwoord4);
    }
    internal void vraag5()
    {
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        string antwoord5 = Console.ReadLine();

        Console.WriteLine(antwoord5);
    }
        internal void vraag6()
    {
        Console.WriteLine("Has someone caught you dancing in front of the mirror?");
        string antwoord6 = Console.ReadLine();

        Console.WriteLine(antwoord6);
    }
}
