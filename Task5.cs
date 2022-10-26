using System;

namespace Task5
{
    public class Task5
    {
        public static string FilteredGuestList(string inputString)
        {
            inputString = inputString.ToUpper();

            //Creating a List 
            //where KeyValuePair is name - surname

            var filteredList = (inputString.Split(';')
                    .Select(x => ToKeyValuePair(x.Split(':'))))
                    .ToList();

            //Filter, that orders by Value(surname) firstly, 
            //and then orders by Key(name) secondly

            filteredList = filteredList.OrderBy(x => x.Value).ThenBy(x => x.Key).ToList();

            //Creating a returning format for a string which includes all friends from the list

            var resultFormat = filteredList.Select(x => string.Format("({0}, {1})", x.Value, x.Key));
            string result = string.Join("", resultFormat);
            return result;
        }


        //Creating an add. function that helps to create a single KeyValuePair string-string in the List

        public static KeyValuePair<string, string> ToKeyValuePair(string[] newArr)
        {
            return new KeyValuePair<string, string>(newArr[0], newArr[1]);
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
