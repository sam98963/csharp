using System;
namespace Solution
{
    class Kata_010
    {
        public static bool IsValidIp(string ipAddress)
        {
          Console.WriteLine(ipAddress);
            string[] subStr = ipAddress.Split(".");
          Console.WriteLine(subStr.Length);
            if(subStr.Length != 4){
              return false;
            }
            foreach(string str in subStr){
              if(str.Contains(" ")){
                return false;
              }
              if(!int.TryParse(str, out int num) || num < 0 || num > 255 || (str.Length > 1 && str[0] == '0')){
                return false;
              }
            }
            return true;
        }
    }
}