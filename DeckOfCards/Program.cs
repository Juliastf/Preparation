using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                String[] cards = new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                String card = Console.ReadLine();
                int index = Array.FindIndex(cards, c => c == card);
                for (int i = 0; i <= index; i++)
                {
                    String currCard = cards[i];
                    Console.WriteLine("{0} of spades, {0} of clubs,{0} of hearts, {0} of diamonds", currCard, currCard, currCard, currCard);
                    //
                }
            }
        }
    }
}