using System;

namespace Snake_And_Ladder_Simulator
{
    class SnakeAndLadder
	{
		const int NO_PLAY = 0;
		const int LADDER = 1;
		const int SNAKE = 2;
		const int WINNING_POSITION = 100;
		public void PlayTillWin()
		{
			int currentPlayerPosition = 0;
			Console.WriteLine("Your starting position : " + currentPlayerPosition);
			while (currentPlayerPosition < WINNING_POSITION)
			{
				Console.WriteLine("Press Enter to Roll Die");
				Console.ReadKey();
				Random random = new Random();
				int rollResult = random.Next(1, 7);
				Console.WriteLine(" You Got : " + rollResult);
				Console.WriteLine(" Press Enter to check for an option ");
				Console.ReadKey();
				int option = random.Next(0, 3);
				switch (option)
				{
					case (NO_PLAY):
						Console.WriteLine(" You got No Play");
						Console.WriteLine("Your position after die roll : " + currentPlayerPosition);
						break;
					case (LADDER):
						Console.WriteLine(" You got Ladder");
						currentPlayerPosition += rollResult;
						Console.WriteLine(" Your position after die roll :" + currentPlayerPosition);
						break;
					case (SNAKE):
						Console.WriteLine(" You got Snake");
						if (currentPlayerPosition >= rollResult)
							currentPlayerPosition -= rollResult;
						else
							currentPlayerPosition = 0;
							Console.WriteLine(" Your position after die roll :" + currentPlayerPosition);
						break;
				}
			}
		}
	}
}

