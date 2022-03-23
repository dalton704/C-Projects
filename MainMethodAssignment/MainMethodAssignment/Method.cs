using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Addition
    {
        public  static int Plus(int numOne)
        {
            int result = numOne + numOne;
            return result;
        }

        public static int Dec(decimal numTwo)
        {
            int resultTwo = Convert.ToInt32(numTwo + numTwo);
            return resultTwo;
        }
    }
}

//public class Deck
//{
//    public Deck()
//    {
//        Cards = new List<Card>();
//        List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
//        List<string> Faces = new List<string>()
//            {
//                "Two", "Three", "Four", "Five", "Six", "Seven",
//                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
//            };

//        foreach (string face in Faces)
//        {
//            foreach (string suit in Suits)
//            {
//                Card card = new Card();
//                card.Suit = suit;
//                card.Face = face;
//                Cards.Add(card);
//            }
//        }