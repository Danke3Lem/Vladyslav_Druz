using System;

namespace Task4
{
    public class Task4
    {
        public static int AmountOfPairsForTargetNumber(int[] inputArr, int targetNum)
        {
            int result = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] + inputArr[j] == targetNum)
                    {
                        result++;
                    }
                }
            }

            return result;
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
}