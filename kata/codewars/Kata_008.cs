using System.Linq;
using System;
public class Kata_008
{
  public static int Gimme(double[] inputArray)
  {
    double maxValue = inputArray.Max();
    double minValue = inputArray.Min();
    for(int i = 0; i<inputArray.Length; i++){
      if(inputArray[i] != maxValue && inputArray[i] != minValue){
        return i;
      }
    }
    return -1;
  }
}