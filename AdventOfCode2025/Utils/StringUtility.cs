namespace AdventOfCode2025.Utils;

public static class StringUtility
{
    public static List<int> StringToIntList(string input)
    {
        List<int> res = new List<int>();

        foreach (char c in input.ToCharArray())
        {
            res.Add((int) char.GetNumericValue(c));
        }

        return res;
    }
}