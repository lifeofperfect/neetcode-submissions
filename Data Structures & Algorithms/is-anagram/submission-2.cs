public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        string sSorted = new string(s.OrderBy(c=>c).ToArray());
        string tSorted = new string(t.OrderBy(c=>c).ToArray());

        return sSorted == tSorted;
    }
}
