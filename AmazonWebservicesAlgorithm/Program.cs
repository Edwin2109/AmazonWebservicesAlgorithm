using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebservicesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckySentence luckySentence = new LuckySentence();
            String[] arrayOfSentences = { "once upon a midnight dreary", "say aaaaah for the dentist", "lima is in peru", "three blind mice see how they run" };
            var sentences = luckySentence.GetLuckiestSentences(arrayOfSentences);
            Console.WriteLine(sentences[0]);
            Console.WriteLine(sentences[1]);
            Console.ReadLine();
        }
    }
}
