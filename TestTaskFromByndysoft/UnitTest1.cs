using NUnit.Framework;
/*
Например, если дан массив [4, 0, 3, 19, 492, -10, 1], 
то результатом будет -10, потому что два минимальных числа -10 и 0, а их сумма -10.
Напишите минимум 3 модульных теста на эту функцию.
HINT: учти, что массив может быть пустым, или без цифр 
или состоять из 100 млн. элементов, поэтому надо учесть разные граничные условия.
*/
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