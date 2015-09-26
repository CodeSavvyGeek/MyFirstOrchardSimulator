using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOrchardSimulator
{
	class Program
	{
		private static int gameCount = 1000000;
		private static int ravenTarget = 6;
		private static int colorTarget = 4;
		private static int colorCount = 4;

		static void Main(string[] args)
		{
			var gamesWon = 0;
			var random = new Random();
			for (int gameIndex = 0; gameIndex < gameCount; gameIndex++)
			{
				if (Runner.Run(new Game(colorCount, colorTarget, ravenTarget))) { gamesWon++; }
			}
			Console.WriteLine("{0}/{1}", gamesWon, gameCount);
			Console.WriteLine((double)gamesWon / (double)gameCount);
		}
	}
}
