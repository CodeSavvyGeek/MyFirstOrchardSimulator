using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOrchardSimulator
{
	public static class Runner
	{
		public static bool Run(Game game)
		{
			var random = new Random();
			while (!game.IsGameOver)
			{
				var roll = random.Next(-2, game.Colors.Count);
				if (roll >= 0) { game.Colors[roll]++; }
				else if (roll == -1) { game.Raven++; }
				else
				{
					int colorIndex = 0;
					for (int i = 1; i < game.Colors.Count; i++) { colorIndex = game.Colors[i] < game.Colors[colorIndex] ? i : colorIndex; }
					game.Colors[colorIndex]++;
				}
			}
			return game.IsColorTargetReached;
		}
	}
}
