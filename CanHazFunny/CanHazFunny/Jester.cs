using System;

namespace CanHazFunny
{
	public class Jester : IJokeService, IJokeOutput
	{
		// redundant _jokeService field, but else leads to infinite regress
		private IJokeService _jokeService;
		private IJokeService jokeService { get => _jokeService; set => _jokeService = value ?? throw new ArgumentNullException();  }
	
		private IJokeOutput _jokeOutput;
		private IJokeOutput jokeOutput { get => _jokeOutput; set => _jokeOutput = value ?? throw new ArgumentNullException(); }
		public Jester(IJokeOutput jokeOutput, IJokeService jokeService)
		{
			this.jokeOutput = jokeOutput;
			this.jokeService = jokeService;
		}

		public string GetJoke()
        {
			string joke;
			do
			{
				joke = jokeService.GetJoke();
			} while (joke.ToLower().Contains("chuck norris"));
			return joke;
        }

		public void outputJoke(string joke)
        {
			Console.WriteLine(joke);
        }

		public void tellJoke()
        {
			outputJoke(GetJoke());
        }
	}
}
