public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> countLetter = new Dictionary<char, int>();

        foreach(char letter in s){
            if(countLetter.ContainsKey(letter)){
                countLetter[letter]++;
            }else{
                countLetter[letter] = 1;
            }
        }

        foreach(char letter in t){
            if(!countLetter.ContainsKey(letter)){
                return false;
            }

            countLetter[letter]--;

            if(countLetter[letter] < 0){
                return false;
            }
        }

        return true;
    }
}
