using ConsoleAppFramework;

class Program
{
    static void Main(string[] args)
    {
        var app = ConsoleApp.Create();

        app.Add<Commands.Commands>();
        app.Run(args);
    }
}