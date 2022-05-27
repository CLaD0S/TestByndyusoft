using NUnit.Framework;

namespace TestTaskFromByndyusoft
{
    using TaskFromByndyusoft;
    using System.Linq;

    public class Tests
    {
        [TestCase]
        public void Test_Utilities_SumMin1()
        {
            int received = Utilities.SumMin(new int[0] { });
            int expected = 0;
            Assert.AreEqual(received, expected);
        }
        [TestCase]
        public void Test_Utilities_SumMin2()
        {
            int received = Utilities.SumMin(new int[1] { 2 });
            int expected = 2;
            Assert.AreEqual(received, expected);
        }
        [TestCase]
        public void Test_Utilities_SumMin3()
        {
            int received = Utilities.SumMin(Enumerable.Range(int.MinValue / 10, int.MaxValue / 10).ToArray());
            int expected = int.MinValue / 10 + int.MinValue / 10 + 1;
            Assert.AreEqual(received, expected);
        }
    }
}