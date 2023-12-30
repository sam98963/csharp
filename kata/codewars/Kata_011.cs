public class Kata_011
{
  public static string Remove(string s)
  {
    for(int i = s.Length-1; i >= 0; i--){
      if(s[i] != '!'){
        return s;
      } else{
        s = s.Remove(i);
      }
    }
    return s;
  }
}