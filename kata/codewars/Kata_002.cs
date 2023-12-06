using System;
public class Kata
{
  public static int SumDigits(int number)
  {
    int result = 0;
    string numStr = Convert.ToString(number);
    int startIndex = (number < 0) ? 1 : 0;
    for(int i = startIndex; i < numStr.Length; i++){
        result += Int32.Parse(numStr[i].ToString());
    }
    return result;
  }
}