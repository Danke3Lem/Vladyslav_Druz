using System;

public class Task1
{
    public static IEnumerable<int> GetIntegersFromList(List<object> elements)
    {
        //Adding only int-type objects

        List<int> result = elements.OfType<int>().ToList();
        return result;
    }
}
