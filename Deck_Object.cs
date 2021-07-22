using System;

namespace Console_Game
{

	public static class DeckObject
{
		//properties
		public int amountOfCards { get; set; };    

		public int[] deck;   //array to hold the random id's for the cards



		//constructors
		public DeckObject();

		public DeckObject(int amountOfCards, int[] deck) 
		{   
			//amountOfCards = numberOfCards;

			//we fill the indexes in the deck with a random number from 1 to 4
			for (int i = 0; i < amountOfCards; ++i;)
			{ deck[i] = Random.Next(1, 4); }

		return deck[];
		}


		// methods
		public int[] Randomizor()



		public void ShuffleDeck() {


	}




//public static class Arrays
//{
//	public static void ArrayStuff(int amountOfCards)
//	{
//		int[] numberArray = new int[5];
//		int[] nArray = new int[] { 12, 5, 9, 15, 45 };

//		string[] names = new string[] { "Luke", "Leia", "Han", "Lando" };

//		foreach (var item in names)
//		{
//			Console.WriteLine();
//		}
//		Console.ReadLine();

//	}

//}


}
