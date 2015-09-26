using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstOrchardSimulator
{
	public class Game
	{
		public Game() : this(4, 4, 6) { }

		public Game(int colorCount, int colorTarget, int ravenTarget)
		{
			this.Colors = new List<int>(Enumerable.Repeat(0, colorCount));
			this.ColorTarget = colorTarget;
			this.RavenTarget = ravenTarget;
		}

		public IList<int> Colors { get; set; }
		public int ColorTarget { get; set; }
		public int Raven { get; set; }
		public int RavenTarget { get; set; }

		public bool IsGameOver { get { return Raven >= this.RavenTarget || this.IsColorTargetReached; } }
		public bool IsColorTargetReached { get { return this.Colors.All(c => c >= this.ColorTarget); } }
	}

}
