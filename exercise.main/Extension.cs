using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Extension
    {
        //TODO: complete the following method, keeping the signature the same
        public bool winningThree(IEnumerable<Tuple<string, string, string>> hand, out Tuple<string, string, string> result)
        {
            result = new Tuple<string, string, string>(string.Empty, string.Empty, string.Empty);
            int highestWinnerPairValue = 0;

            foreach (var pair in hand)
            {
                var score = GetValueOfCard(pair.Item1) + GetValueOfCard(pair.Item2);

                if (pair.Item1 == pair.Item2 && pair.Item2 == pair.Item3 && score > highestWinnerPairValue)
                {
                    result = new Tuple<string, string, string>(pair.Item1, pair.Item2, pair.Item3);
                    highestWinnerPairValue = score;
                }
            }

            return false;
        }

        public int GetValueOfCard(string card)
        {
            switch (card)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 0;
            }
        }
    }
}
