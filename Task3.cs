using System;
using System.Security.Cryptography.X509Certificates;

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