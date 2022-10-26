using System;

namespace Task1
{
    public class Task1
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> elements)
        {
            //Adding only int-type objects

            List<int> result = elements.OfType<int>().ToList();
            return result;
        }
    }

    public class Tests1 // Task 1.1
    {
        [Test]  // Test #1 for Task 1.1
        public static void Test1()
        {
            //Arrange
            List<object> list = new List<object>();
            list.Add(1);
            list.Add(2);
            list.Add("bbb");

            List<object> expected = new List<object>();
            expected.Add(1);
            expected.Add(2);

            //Act
            List<int> actual = new List<int>(Task1.GetIntegersFromList(list));

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test] // Test #2 for Task 1.1
        public static void Test2()
        {
            //Arrange
            List<object> list = new List<object>();
            list.Add("15");
            list.Add(5);
            list.Add("5bb");
            list.Add("0");
            list.Add(9);

            List<object> expected = new List<object>();
            expected.Add(5);
            expected.Add(9);

            //Act
            List<int> actual = new List<int>(Task1.GetIntegersFromList(list));

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
