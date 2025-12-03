namespace AdventOfCode2025.Days;

public class Day03 : Day
{
    public override string Part1(string filename)
    {
        string[] input = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename)).Split('\n');
        int acc = 0;
        foreach (string line in input)
        {
            List<int> list = Utils.StringUtility.StringToIntList(line);
            var maxInfo = list.SkipLast(1)
                .Select((value, index) => new { Value = value, Index = index })
                .Aggregate((agg, next) => next.Value > agg.Value ? next : agg);

            int nextMax = list.Skip(maxInfo.Index + 1).Max();

            acc += maxInfo.Value * 10 + nextMax;
        }
        return acc.ToString();
    }
    
    public override string Part2(string filename)
    {
        string[] input = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename)).Split('\n');
        long acc = 0;
        foreach (string line in input)
        {
            List<int> list = Utils.StringUtility.StringToIntList(line);

            int skips = 11;
            int headSkip = 0;
            while (skips >= 0)
            {
                var maxInfo = list.SkipLast(skips).Skip(headSkip)
                    .Select((value, index) => new { Value = value, Index = index + headSkip })
                    .Aggregate((agg, next) => next.Value > agg.Value ? next : agg);
                acc += maxInfo.Value * (long) Math.Pow(10, skips);
                skips -= 1;
                headSkip = maxInfo.Index + 1;
            }
        }
        return acc.ToString();
    }
}