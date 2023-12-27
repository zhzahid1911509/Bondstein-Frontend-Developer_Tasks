/* C# code to find two indices from a list of numbers in non-decreasing order 
whose values add up to be the given number.
*/
using System;

public class Task3
{
    public static void findIndices(int[] myNumbers, int targetNum)
    {
        int sumValue = 0;
        int left = 0;
        int right = myNumbers.Length - 1;
        while (left < right)
        {
            sumValue = myNumbers[left] + myNumbers[right];
            if (sumValue == targetNum)
            {
                Console.WriteLine("Indices: " + left + "," + right);
                 return;
            }
            else if (sumValue < targetNum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        Console.WriteLine("No indices found with values adding up to " + targetNum);
    }

    public static void Main(string[] args)
    {
        int[] numbersList = { 3, 5, 6, 10, 11 };
        int targetNum = 15;
        findIndices(numbersList, targetNum);
    }
}
