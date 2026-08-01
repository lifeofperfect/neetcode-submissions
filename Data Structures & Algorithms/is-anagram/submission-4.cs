public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> freq = new Dictionary<char, int>();

//o(n)
        foreach(char i in s){
            if(freq.ContainsKey(i)){
                freq[i]++;
            }else{
                freq[i] = 1;
            }
        }

        foreach(char i in t){
            if(freq.ContainsKey(i)){
                freq[i]--;
                if(freq[i] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }

        return true;
    }
}
