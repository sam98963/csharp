using System;
using System.Collections.Generic;
using System.Linq;

public class Kata_009
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    List<int> result = new List<int>(numbers);
    if(numbers.Count == 0){
      return new List<int>(); 
    } else {
      int min = numbers.Min();
      result.Remove(min);
      }
    return result;
    }
  }
    