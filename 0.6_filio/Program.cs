using System.Data;
using System.Diagnostics;

namespace _0._6_filio;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World 2!");

        Program program = new Program();
        program.Run();
    }
    void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
    }
}
