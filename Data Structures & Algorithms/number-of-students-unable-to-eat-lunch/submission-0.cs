public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int res = students.Length;
        int[] cnt = {0,0};
        foreach(int student in students) {
            if (student == 0) {
                cnt[0]++;
            } else {
                cnt[1]++;
            };
        }

        for (int i = 0; i < sandwiches.Length; i++) {
            if (cnt[sandwiches[i]] != 0) {
                cnt[sandwiches[i]]--;
                res--;
            } else if (cnt[sandwiches[i]] == 0) {
                break;
            }
        }
        
        return res;
    }
}