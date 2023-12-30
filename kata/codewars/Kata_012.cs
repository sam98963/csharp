using System;
using System.Collections;
public class Kata_012
{
  public static int[] FindMissingNumbers(int[] arr)
  {
    if (arr == null || arr.Length == 0){
            return new int[0];
        }
    ArrayList arrList = new ArrayList();
    for(int i = arr[0]; i<=arr[arr.Length-1]; i++){
      Console.WriteLine(i);
      if (Array.IndexOf(arr, i) == -1){
            arrList.Add(i);
      }
    }
    int[] result = arrList.ToArray(typeof(int)) as int[];
    return result;
  }
}