public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(var str in strs){
            string sortedStr = new string(str.OrderBy(c=> c).ToArray());

            if(map.ContainsKey(sortedStr)){
                map[sortedStr].Add(str);
            }else{
                map[sortedStr] = new List<string>() {str};
            }
        }

        return map.Values.ToList();
    }
}
