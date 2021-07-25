using System;

namespace Snake_And_Ladder_Simulator
{
    class SnakeAndLadder
	{
		const int START_POSITION = 0;
	    const int NO_PLAY = 0;
		const int LADDER = 1;
		const int SNAKE = 2;

		public void GetOption()
		{
			int currentPlayerPosition = START_POSITION;
			Console.WriteLine("Your starting position : " + START_POSITION);
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
					break;
				case (LADDER):
					Console.WriteLine(" You got Ladder");
					currentPlayerPosition += rollResult;
					Console.WriteLine(" Your position after dice :" + currentPlayerPosition);
					break;
				case (SNAKE):
					Console.WriteLine(" You got Snake");
					currentPlayerPosition -= rollResult;
					Console.WriteLine(" Your position after dice :" + currentPlayerPosition);
					break;
			}
		}
	}
}
