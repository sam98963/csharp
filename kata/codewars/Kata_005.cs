using System;

public static class Kata_005
{
  public static int SumOfDifferences(int[] arr)
  {
    if(arr.Length < 2){
      return 0;
    }
    int difference = 0;
    Array.Sort(arr);
    Array.Reverse(arr);
    for(int i = 0; i < arr.Length - 1; i++){
      difference += (arr[i] - arr[i + 1]);
    }
    return difference;
  }
}