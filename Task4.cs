using System;

public class Task4
{
	public static int AmountOfPairsForTargetNumber(int[] inputArr, int targetNum)
	{
		int result = 0;

		for(int i = 0; i < inputArr.Length; i++)
		{
			for(int j = i + 1; j <inputArr.Length; j++)
			{
				if(inputArr[i] + inputArr[j] == targetNum)
				{
					result++;
				}
			}
		}

		return result;
	}
}
