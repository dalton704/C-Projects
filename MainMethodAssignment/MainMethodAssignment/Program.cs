using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, let's do some Math Operations!");
            Console.WriteLine("\nPlease input a number to be added to itself.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int adding = Addition.Plus(numOne);
            Console.WriteLine(numOne + " plus " + numOne + " is equal to " + adding + ".");

            Console.WriteLine("\nLet's try a decimal this time.");
            decimal numTwo = Convert.ToDecimal(Console.ReadLine());
            int addingTwo = Addition.Dec(numTwo);
            Console.WriteLine(numTwo + " plus " + numTwo + " is equal to " + addingTwo + " (rounded up.)");
            
            
            Console.ReadLine();


        }
    }
}

//namespace TwentyOne
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Deck deck = new Deck();
//            int timesShuffled = 0;
//            deck = Shuffle(deck, out timesShuffled, 3);

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }
//            Console.WriteLine(deck.Cards.Count());
//            Console.WriteLine("Times shuffled: {0}", timesShuffled);
//            Console.ReadLine();
//        }

//        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
//        {
//            timesShuffled = 0;
//            for (int i = 0; i < times; i++)
//            {
//                timesShuffled++;
//                List<Card> TempList = new List<Card>();
//                Random random = new Random();

//                while (deck.Cards.Count > 0)
//                {
//                    int randomIndex = random.Next(0, deck.Cards.Count);
//                    TempList.Add(deck.Cards[randomIndex]);
//                    deck.Cards.RemoveAt(randomIndex);
//                }
//                deck.Cards = TempList;
//            }

//            return deck;

//        }