public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> keyedAnagram = new Dictionary<string, List<string>>();

        foreach(string str in strs){
            var strArray = str.ToCharArray();

            Array.Sort(strArray);

            string sortedKey = new string(strArray);

            if(!keyedAnagram.ContainsKey(sortedKey)){
                keyedAnagram[sortedKey] = new List<string>(){};
            }

            keyedAnagram[sortedKey].Add(str);
        }

        return new List<List<string>>(keyedAnagram.Values);
    }
}
