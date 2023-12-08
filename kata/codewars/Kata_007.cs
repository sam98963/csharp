using System;
using System.Collections;
using System.Linq;
public class Kata_007
{
  public static int[] VowelIndices(string word)
  {
    ArrayList arrl = new ArrayList(); 
    for(int i = 0; i < word.Length; i++){
      char c = char.ToLower(word[i]);
      if(c.Equals('e') || c.Equals('a') || c.Equals('i') || c.Equals('o') || c.Equals('u') || c.Equals('y')){
        arrl.Add(i+1);
      }
    }
    int[] result = arrl.OfType<int>().ToArray();
    return result;
  }
}