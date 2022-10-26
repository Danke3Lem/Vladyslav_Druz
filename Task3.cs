using System;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    public class Task3
    {
        public static int DigitalRoot(int inputNum)
        {
            if (inputNum < 10) return inputNum;     //Checking for valid range of input
            else if (inputNum < 0) return -1;

            int result = 0;

            while (inputNum > 0)
            {
                result += inputNum % 10;
                inputNum /= 10;
            }

            if (result <= 9) return result;
            else return DigitalRoot(result);
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
}