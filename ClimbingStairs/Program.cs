public class Solution
{
    private int[] _memo;
    public Solution()
    {
        _memo = new int[50];
    }
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        else if (n == 2) return 2;
        else if (_memo[n] != 0)
            return _memo[n];
        else
        {
            _memo[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            return _memo[n];
        }
    }
}