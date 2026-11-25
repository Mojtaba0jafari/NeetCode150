public class Solution
{
    public int HammingWeight(int n)
    {
        string binaryRep = "";
        int result = 0;
        while (n > 0)
        {
            binaryRep = (n % 2).ToString() + binaryRep;
            n /=2;
        }

        foreach (char c in binaryRep) 
            if (c == '1') result++;

        return result;
    }
}