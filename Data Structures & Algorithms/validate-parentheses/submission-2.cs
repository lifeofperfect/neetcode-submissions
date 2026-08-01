public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();

        foreach(char chara in s){
            if(chara=='(' || chara=='[' || chara=='{'){
                brackets.Push(chara);
            }
            else{
                if(brackets.Count ==0){
                    return false;
                }

                char lastpop = brackets.Pop();

                if(chara == ')' && lastpop != '('){
                    return false;
                }

                if(chara == '}' && lastpop != '{'){
                    return false;
                }

                if(chara == ']' && lastpop != '['){
                    return false;
                }
            }
        }

        return brackets.Count == 0;
    }
}
