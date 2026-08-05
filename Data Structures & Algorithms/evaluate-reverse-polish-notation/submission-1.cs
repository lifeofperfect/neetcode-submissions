public class Solution {
    public int EvalRPN(string[] tokens) {
        List<int> numbers = new List<int>();

        foreach(string token in tokens){
            if(int.TryParse(token, out int number)){
                numbers.Add(number);
            }else{
                int secondNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);

                int firstNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);

                int ans;

                if(token == "+"){
                    ans = firstNumber + secondNumber;
                }else if (token == "-"){
                    ans = firstNumber - secondNumber;
                }else if(token == "*"){
                    ans = firstNumber * secondNumber;
                }else{
                    ans = firstNumber/secondNumber;
                }

                numbers.Add(ans);
            }
        }

        return numbers[0];
    }
}
