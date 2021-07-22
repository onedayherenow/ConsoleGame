using System;
using Console_Game;


namespace Console_Game;

{

		public static class PlayerOne
		{
			//properties
			public string name;
			public double percentageScore = (Convert.ToDouble(score) / DeckObject.amountOfCards);
			public int score;

			//constructors
			PlayerOne();

			PlayerOne(string Name)
			{
				name = Name;
			}

			//methods
		}



		public static class PlayerTwo
		{
			//properties
			public string name;
			public double percentageScore = (Convert.ToDouble(score) / DeckObject.amountOfCards);
			public int score;

			//constructors
			PlayerOne();

			PlayerOne(string Name)
			{
				name = Name;
			}

			//methods
		}

}
