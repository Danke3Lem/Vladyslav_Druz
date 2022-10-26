using System;

namespace Task2
{
    public class Task2
    {
        public static char First_Non_Repeating_Letter(string inputString)
        {
            //Dictionary was selected to count the amount of specific char

            Dictionary<char, int> allLettersFromTheString = new Dictionary<char, int>();
            string originalInputString = inputString;

            //String is lower to count specific letter, where upper case is included as well
            inputString = inputString.ToLower();
            int tmp = 0;

            foreach (char ch in inputString.ToCharArray())
            {
                if (allLettersFromTheString.ContainsKey(ch))
                {
                    tmp = allLettersFromTheString[ch];
                    allLettersFromTheString[ch] = tmp + 1;

                    continue;
                }


                allLettersFromTheString.Add(ch, 1);
            }

            //Find the first char that has value == 1 (was repeated once)

            if (allLettersFromTheString.Values.Contains(1))
            {
                char resultCh = allLettersFromTheString.First(x => x.Value == 1).Key;
                var index = inputString.IndexOf(resultCh);
                bool IsLetterUpper = Char.IsUpper(originalInputString, index);

                if (IsLetterUpper)
                {
                    return Char.ToUpper(resultCh);
                }

                return Char.ToLower(resultCh);
            }

            else
            {
                return ' '; //Empty char
            }
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
}
