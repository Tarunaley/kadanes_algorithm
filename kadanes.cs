using System;

public static class SubarrayUtils
{
    public static int MaxSubarraySum(int[] numbers,out int start,out int end)
    {
        if(numbers==null || numbers.Length==0)
        {
            throw new ArgumentException("Input array cannot be null or empty.",nameof(numbers));
        }

        int maxSum=numbers[0];
        int currSum=numbers[0];

        start=0;
        end=0;
        int tempStart=0;

        for(int i=1;i<numbers.Length;i++)
        {
            if(numbers[i]>currSum+numbers[i])
            {
                currSum=numbers[i];
                tempStart=i;
            }
            else
            {
                currSum+=numbers[i];
            }

            if(currSum>maxSum)
            {
                maxSum=currSum;
                start=tempStart;
                end=i;
            }
        }

        return maxSum;
    }
}