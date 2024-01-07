public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(s);
        int count = 0;
        for(int i = 0; i<g.Length; i++){
            for(int j = 0; j<s.Length; j++){
                if(g[i] <= s[j]){
                    s[j] = 0;
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}