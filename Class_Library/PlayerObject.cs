using System;
using Console_Game;


namespace Console_Game

{

	public class PlayerOne
	{
		//properties
		public string name;
		public double percentageScore;
		public static int score;

		//constructors
		PlayerOne() { }

		PlayerOne(string Name)
		{
			name = Name;
		}

		//methods

		public double PercentageMaker(int score, int amountOfCards)
		{


			double percentage = (Convert.ToDouble(score) / Convert.ToDouble(DeckObject.amountOfCards));
			return percentage;
		}



		public class PlayerTwo
		{
			//properties
			public string name;
			public double percentageScore = PercentageMaker();
			public static int score;

			//constructors
			PlayerTwo() { }

			PlayerTwo(string Name)
			{
				name = Name;
			}

			//methods
		}

	}
}
