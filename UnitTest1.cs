using System.Xml.Linq;

namespace Task1Tests
{
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

    public class Tests2 // Task 1.2
    {
        [Test]  // Test #1 for Task 1.2
        public static void Test3()
        {
            //Arrange
            string inputString = "stress";
            char expected = 't';

            //Act
            char actual = Task2.First_Non_Repeating_Letter(inputString);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]  // Test #2 for Task 1.2
        public static void Test4()
        {
            //Arrange
            string inputString = "sTreSS";
            char expected = 'T';

            //Act
            char actual = Task2.First_Non_Repeating_Letter(inputString);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]  // Test #3 for Task 1.2
        public static void Test5()
        {
            //Arrange
            string inputString = "ShLlahSa"; // The string, where all letters are repeated twice
            char expected = ' ';

            //Act
            char actual = Task2.First_Non_Repeating_Letter(inputString);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

    public class Tests3 // Task 1.3
    {
        [Test]  // Test #1 for Task 1.3
        public static void Test6()
        {
            //Arrange
            int inputNum = 942;
            int expectedNum = 6;

            //Act
            int actualNum = Task3.DigitalRoot(inputNum);

            //Assert
            Assert.AreEqual(expectedNum, actualNum);
        }

        [Test]  // Test #2 for Task 1.3
        public static void Test7()
        {
            //Arrange
            int inputNum = 493193;
            int expectedNum = 2;

            //Act
            int actualNum = Task3.DigitalRoot(inputNum);

            //Assert
            Assert.AreEqual(expectedNum, actualNum);
        }
    }

    public class Tests4 // Task 1.4
    {
        [Test]  // Test #1 for Task 1.4
        public static void Test8()
        {
            //Arrange
            int[] inputArr = new int[] { 1, 3, 6, 2, 2, 0, 4, 5 };
            int targetNum = 5;
            int expected = 4;

            //Act
            int actual = Task4.AmountOfPairsForTargetNumber(inputArr, targetNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]  // Test #2 for Task 1.3
        public static void Test9()
        {
            // Arrange
            int[] inputArr = new int[] { 5, 1, 4, 6, 3, 0, 2, 1 };
            int targetNum = 6;
            int expected = 4;

            //Act
            int actual = Task4.AmountOfPairsForTargetNumber(inputArr, targetNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Tests5 // Task 1.5
    {
        [Test]  // Test #1 for Task 1.5
        public static void Test10()
        {

            //The expected string was copying from the task in
            //exact format(without spaces between friends; 'Fred' instead of 'Fired' etc.)

            //Arrange
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            //Act
            string actual = Task5.FilteredGuestList(s);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]  // Test #2 for Task 1.3
        public static void Test11()
        {

            //The same string as in Test10, but added another one Fred:Corwill
            //to show that a function's list contains all guests, even their name and surname repeat

            //Arrange
            string s = "Fred:Corwill;Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            //Act
            string actual = Task5.FilteredGuestList(s);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}