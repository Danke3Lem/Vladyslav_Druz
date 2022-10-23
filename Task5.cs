using System;

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
