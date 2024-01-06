namespace CountEmails
{
  public static class Kata_013
  {
    public static string CountEmails(int sent, int? limit = null)
    {
      int percentAsInt;
      if(!limit.HasValue || limit <= 0){
        limit = 1000;
      }
      if(sent >= limit){
        return "Daily limit is reached";
      } else if(sent == 0){
        return "No e-mails sent";
      } else {
        double? percent = ((double)sent / limit.Value) * 100;
        percentAsInt = (int)percent;
      }
      return percentAsInt.ToString() + "%";
    }
  }
}