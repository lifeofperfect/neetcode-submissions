public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;

        while(left < right){

            while(left < right && !char.IsLetterOrDigit(s[left])){
                left++;
            }

            while(left < right && !char.IsLetterOrDigit(s[right])){
                right--;
            }

            char lChar = char.ToLower(s[left]);
            char rChar = char.ToLower(s[right]);

            if(lChar != rChar){
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
