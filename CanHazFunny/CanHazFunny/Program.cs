namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            new Jester(new JokeConsoleOutput(), new JokeService()).tellJoke();
        }
    }
}
