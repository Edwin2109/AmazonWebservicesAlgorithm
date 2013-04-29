using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebservicesAlgorithm
{
    /// <summary>
    /// Accepts an input string array of sentences and returns out the 2 "luckiest" sentences
    /// where "luck" is measured by the number of "lucky" words in the sentence.
    /// </summary>
    public class LuckySentence
    {
        private int CountLuckyWords(String sentence)
        {
            int luckyWordsCount = 0;
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                int count = 0;
                foreach (char character in word)
                {
                    if ((int)(character - 'a') % 2 == 0)
                        count++;
                }
                if (count >= 4)
                    luckyWordsCount++;
            }
            return luckyWordsCount;
        }

        public List<string> GetLuckiestSentences(String[] arrayOfSentences)
        {
            List<string> luckiestSentences = new List<string>();
            //Validate if the input is supplied 
            if (Array.Equals(arrayOfSentences,null))
                throw new ArgumentNullException("Input should not be null.");

            //Initialize a container array for counting lucky words
            int[] containerArray = new int[arrayOfSentences.Length];
            int max1 = -1;
            int x = 0;
            //Iterate the array of provided sentences
            foreach (string sentence in arrayOfSentences)
            {
                containerArray[x] = CountLuckyWords(sentence);
                if (max1 < 0)
                    max1 = x;
                else if (containerArray[x] > containerArray[max1])
                    max1 = x;
                x++;
            }
            //Add the first sentence if any
            luckiestSentences.Add(arrayOfSentences[max1]);

            int max2 = -1;
            for (int i = 0; i < arrayOfSentences.Length; ++i) 
            {
                if (i == max1)
                    continue;
                if (max2 < 0)
                    max2 = i;
                else if (containerArray[i] > containerArray[max2])
                    max2 = i;
            }
            //Add the second sentence if any
            luckiestSentences.Add(arrayOfSentences[max2]);

            return luckiestSentences;
        }
    }
}
