public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        var counts = new Dictionary<char, int>();

        foreach(char ch in s){
            counts.TryGetValue(ch, out int count);

            counts[ch] = count + 1;
        }

        foreach(char ch in t){
            if(!counts.TryGetValue(ch, out int count)){
                return false;
            }

            count--;

            if(count < 0){
                return false;
            }

            if(count == 0){
                counts.Remove(ch);
            }else{
                counts[ch] = count;
            }
        }

        return true;
    }
}
