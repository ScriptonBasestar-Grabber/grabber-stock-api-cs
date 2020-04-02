using System;
using System.IO;
using NUnit.Framework;

namespace XingBotTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Assert.Pass();
            string text = File.ReadAllText("./res/CDPCQ04700.h");
            Console.WriteLine(text);
        }
    }
}