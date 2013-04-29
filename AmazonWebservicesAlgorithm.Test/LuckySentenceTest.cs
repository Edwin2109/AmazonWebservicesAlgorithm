using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonWebservicesAlgorithm.Test
{
    [TestClass]
    public class LuckySentenceTest
    {
        private LuckySentence luckySentence;
        private String[] arrayOfSentences;

        [TestInitialize]
        public void Setup()
        {
            luckySentence = new LuckySentence();
            arrayOfSentences = new string[] { "aaaa aaaa aaaa bbbb", "aaaa aaaa aaaa aaaa", "aaaa aaaa aaaa aaae" };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetLuckiestSentencesThrowsNullException()
        {
            //Passing a null to see if the method does throw a ArgumentNullException.
            //In this case we using a ExpectedException attribute.
            var sentences = luckySentence.GetLuckiestSentences(null);
        }

        [TestMethod]
        public void GetLuckiestSentencesReturnsCorrectOutput()
        {
            //Pass in array of sentences,
            var sentences = luckySentence.GetLuckiestSentences(arrayOfSentences);

            //Create an expected list of strings to compare against,
            List<string> luckiestTestSentences = new List<string>();
            luckiestTestSentences.Add("aaaa aaaa aaaa aaaa");
            luckiestTestSentences.Add("aaaa aaaa aaaa aaae");

            //Use CollectionAssert.AreEqual to compare our actual list against our expected list.
            CollectionAssert.AreEqual(luckiestTestSentences, sentences);
        }
    }
}
