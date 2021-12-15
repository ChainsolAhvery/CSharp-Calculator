using NUnit.Framework;
using static C_Sharp_Calculator.Helpers;


namespace C_Sharp_Calculator_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SquareRootTest1()
        {
            decimal Expected = 2.91547594742265M;
            decimal Result = SquareRoot(8.5M);
            Assert.AreEqual(Expected, Result);
        }
        public void SquareRootTest2()
        {
            decimal Expected = 2.91547594742265M;
            decimal Result = SquareRoot(8.5M);
            Assert.AreEqual(Expected, Result);
        }
        public void SanityTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}