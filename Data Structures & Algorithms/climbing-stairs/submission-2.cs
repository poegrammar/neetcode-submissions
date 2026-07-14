public class Solution {
    public int ClimbStairs(int n) {
        int _one = 1;
        int _two = 1;
        for (int i = 1; i < n; i++) {
            int stub = _one + _two;
            _two = _one;
            _one = stub;
        }
        return _one;
    }
}
