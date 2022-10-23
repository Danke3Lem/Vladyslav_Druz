using System;

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
