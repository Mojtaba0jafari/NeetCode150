public class Solution
{
    public bool IsValid(string s)
    {
        string expected_end = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                expected_end = ")" + expected_end;
            else if (s[i] == '{')
                expected_end = "}" + expected_end;
            else if (s[i] == '[')
                expected_end = "]" + expected_end;

            else if ((s[i] == ')' || s[i] == '}' || s[i] == ']') 
                && expected_end.Length != 0)
            {
                if (expected_end[0] == s[i])
                    expected_end = expected_end.Substring(1);
                else
                    return false;
            }
            else if (expected_end.Length == 0)
                return false;
        }
        if (expected_end.Length == 0)
            return true;
        else 
            return false;
    }
}