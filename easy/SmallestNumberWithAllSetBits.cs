namespace leetcode.easy {
    public class SmallestNumberWithAllSetBits {
        public int SmallestNumber(int n) {
            int x = 1;
            while (x - 1 < n) {
                x <<= 1;
            }
            return x - 1;
        }
    }
}