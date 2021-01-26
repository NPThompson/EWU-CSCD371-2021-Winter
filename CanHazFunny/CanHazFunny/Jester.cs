using System;

namespace CanHazFunny
{
	public class Jester : IJokeService, IJokeOutput
	{
		// redundant _jokeService field, but else leads to infinite regress
		private IJokeService _jokeService;
		private IJokeService jokeService { get => _jokeService; set => _jokeService = value ?? throw new ArgumentNullException();  } 
		
		public Jester(IJokeService jokeService)
		{
			this.jokeService = jokeService;
		}

		public string GetJoke()
        {
			return "";
        }

		public void outputJoke(string joke)
        {

        }
	}
}
