using System;
namespace Case.Services{
  public class CaseService{
    public string capitaliseFirst(string input){
      return input[0].ToString().ToUpper() + input.Substring(1);
    }
    public string lowerFirst(string input){
      return input[0].ToString().ToLower() + input.Substring(1);
    }

    public string[] splitStrings(string input){
      if (string.IsNullOrEmpty(input)){
        return new string[0];
      }
      string[] words = input.Split(" ");
      for (int i = 0; i<words.Length; i++){
        words[i] = capitaliseFirst(words[i]);
      }
      return words;
    }

    public string connectStrings(string[] input, string seperator){
      return string.Join(seperator, input);
    }

    public string trainCase(string input){
      return connectStrings(splitStrings(input), "-");
    }
  }
}
