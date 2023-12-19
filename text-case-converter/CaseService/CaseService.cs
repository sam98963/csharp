using System;
namespace Case.Services{
  public class CaseService{
    public string capitaliseFirst(string input){
      return input[0].ToString().ToUpper() + input.Substring(1);
    }
  }
}
