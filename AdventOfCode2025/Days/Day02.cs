using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2025.Days;

public class Day02 : Day
{
    public override string Part1(string filename)
    {
        string[] ranges = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename)).Trim().Split(',');
        long acc = 0;
        foreach (string range in ranges)
        {
            (string start, string end) = range.Split('-') switch { var s => (s[0], s[1]) };
            long startInt = long.Parse(start);
            long endInt = long.Parse(end);

            for (long i = startInt; i <= endInt; i++)
            {
                string s = i.ToString();
                int half = s.Length / 2;
                if (s[..half] == s[half..])
                {
                    acc += i;
                }
            }
        }
        return acc.ToString();
    }
    
    public override string Part2(string filename)
    {
        string[] ranges = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename)).Trim().Split(',');
        long acc = 0;
        foreach (string range in ranges)
        {
            (string start, string end) = range.Split('-') switch { var s => (s[0], s[1]) };
            long startLong = long.Parse(start);
            long endLong = long.Parse(end);

            for (long i = startLong; i <= endLong; i++)
            {
                string s = i.ToString();
                for (int j = 0; j < s.Length / 2 + 1; j++)
                {
                    if (j + 1 == s.Length)
                    {
                        break;
                    }
                    Regex re = new Regex(s[..(j + 1)]);
                    int numMatches = re.Matches(s).Count();
                    if ((numMatches == s.Length / (j + 1)) && s.Length % (j + 1) == 0)
                    {
                        acc += i;
                        break;
                    }
                }

            }
        }
        return acc.ToString();
    }
}