public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int lastNum = temperatures.Length;
        int[] result = new int[lastNum];

        for(int i=0; i<lastNum; i++){
            for(int j = i+1; j<lastNum; j++){
                if(temperatures[j] > temperatures[i]){
                    result[i] = j -i;

                    break;
                }
            }
        }

        return result;
    }
}
