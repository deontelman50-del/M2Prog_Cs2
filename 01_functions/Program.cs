namespace _01_functions;

    internal class Program
{
    string[] vragen = new string[]
    {
        "What 1997 N64 video game, features James Bond and is named after the 1995 film?",
        "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?",
        "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?",
        "Making his debut in 1990's Super Mario World, what is the name of the enemy-eating, egg-throwing green dinosaur who serves as a sidekick to Mario and Luigi in the Mario franchise?"

    };
    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }


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
        Program.vraag7();
        
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
        internal string vraag7()
    {
        Console.WriteLine("");
        string antwoord7 = Console.ReadLine();

        return antwoord7;
        
    }
    
}
