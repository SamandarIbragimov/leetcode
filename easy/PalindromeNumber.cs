namespace leetcode.easy {
    public class PalindromeNumber {
        public bool IsPalindrome(int x) {
            if(x < 0 || (x % 10 == 0 && x != 0)) {
                return false;
            }
            int half = 0;
            while (x > half) {
                half = half * 10 + x % 10;
                x = x / 10; 
            }
            return x == half || x == half / 10;
        }
    }
}