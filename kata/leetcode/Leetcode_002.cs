public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(int i = 1; i<s.Length; i++){
            if(s.Length % i == 0){
                string substr = s.Substring(0, i);
                StringBuilder builder = new StringBuilder();
                for(int j = 0; j < s.Length / i; j++){
                    builder.Append(substr);
                }
                if(builder.ToString() == s){
                    return true;
                }
            }
           
        }
        return false;
    }
}