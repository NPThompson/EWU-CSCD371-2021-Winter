using System;

namespace CanHazFunny
{
	public class Jester : IJokeService, IJokeOutput
	{
		private IJokeService jokeService { get => jokeService; set => jokeService = value ?? throw new ArgumentNullException();  } 

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
