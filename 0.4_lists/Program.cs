namespace _0._4_lists;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    internal void Run ()
    {
        double[] prijzen = new double[] { 0.99, 5.60, 10.11 };
        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu"};
        Formulier[] formulieren = new Formulier[2];
        formulieren[0] = new Formulier()
    {
        Feedback = "prijzig maar lekker",
        Sterren = 5,
        Prijzen = 10.11
    };
        formulieren[1] = new Formulier()
        {
            Feedback = "lekker en goedkoop",
            Sterren = 4,
            Prijzen = 0.99
        };
        for (int i= 0; i  < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
        }
    }


}
