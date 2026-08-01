public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder cleaned = new StringBuilder();

        foreach(char chara in s){
            if(char.IsLetterOrDigit(chara)){
                cleaned.Append(char.ToLower(chara));
            }
        }

        int left = 0;
        int right = cleaned.Length - 1;

        while(left < right){
            if(cleaned[left] != cleaned[right]){
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
