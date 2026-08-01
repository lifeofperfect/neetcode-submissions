class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if(s.length != t.length) return false

        var counts = new Map();

        for(const ch of t){
            let count = counts.get(ch) ?? 0;

            counts.set(ch, count+1)
        }

        for(const ch of s){
            if(!counts.has(ch)) return false

            let count = counts.get(ch)

            count--;

            if(count < 0) return false

            if(count == 0){
                counts.delete(ch)
            }else {
                counts.set(ch, count)
            }

            
        }

        return true
    }
}
