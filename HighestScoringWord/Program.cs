using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestScoringWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(High("test testing juliano"));
            Console.WriteLine(High("man i need a taxi up to ubud"));
            Console.WriteLine(High("what time are we climbing up to the volcano"));
            Console.WriteLine(High("take me to semynak"));
            Console.ReadLine();
        }

        public static string High(string s)
        {
            string highestScoreWord = s.Split()[0];
            int highestScore = 0;
            int score = 0;
            foreach(var word in s.Split())
            {
                score = Score(word);
                //Console.WriteLine(word + " - " + score.ToString() + " - " + highestScore);
                if (score > highestScore)
                {
                    highestScore = score;
                    highestScoreWord = word;
                }
                    

            }
            return highestScoreWord;
        }

        public static int Score(string str)
        {
            int sum = 0;
            foreach (var c in str)
                sum += ((int)c)-96;
            return sum;
        }
    }
}
