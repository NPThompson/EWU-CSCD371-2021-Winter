using System;

namespace CanHazFunny
{
	public class JokeConsoleOutput : IJokeOutput
	{
		public JokeConsoleOutput()
		{
		}

		public void outputJoke(string joke)
		{
			Console.WriteLine(joke);
		}
	}
}
