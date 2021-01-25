using System;

namespace CanHazFunny
{
	public class Jester : IJokeService, IJokeOutput
	{
		public Jester()
		{
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
