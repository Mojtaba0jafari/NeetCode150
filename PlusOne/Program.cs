public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int carry = 0;
        int sum = 1;
        int temp = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (sum == 0 && carry == 0)
                break;

            temp = carry + sum + digits[i];
            sum = 0;
            if (temp >= 10)
            {
                carry = 1;
                digits[i] = temp - 10;
            }
            else
            {
                carry = 0;
                digits[i] = temp;
            }
        }
        if (carry == 1)
        {
            int[] newdigits = new int[digits.Length + 1];
            newdigits[0] = carry;
            for (int i = 0; i < digits.Length; i++)
                newdigits[i + 1] = digits[i];
            return newdigits;
        }

        return digits;
    }
}