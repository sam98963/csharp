using System;
namespace Case.Services{
  public class CaseService{
    public string capitaliseFirst(string input){
      return input[0].ToString().ToUpper() + input.Substring(1);
    }

    public string[] splitStrings(string input){
      string[] words = input.Split(" ");
      for (int i = 0; i<words.Length; i++){
        words[i] = capitaliseFirst(words[i]);
      }
      return words;
    }

    public string connectStrings(string[] input, string connector){
      return string.Join(connector, input);
    }

    public string trainCase(string input){
      return connectStrings(splitStrings(input), "-");
    }
  }
}
