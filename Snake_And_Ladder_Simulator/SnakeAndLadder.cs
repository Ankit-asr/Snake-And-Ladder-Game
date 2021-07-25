using System;

namespace Snake_And_Ladder_Simulator
{
    class SnakeAndLadder
	{
		int startPosition = 0;
		public void RollsDice()
		{
			Console.WriteLine("Player starting position : " + startPosition);
			Random random = new Random();
			int diceRoll = random.Next(1, 7);
			Console.WriteLine("Player Got : " + diceRoll);
		}
	}
}
