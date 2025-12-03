namespace AdventOfCode2025.Days;

public class Day01 : Day
{
    private static int ParseDial(string input)
    {
        int res;
        if (input.Length <= 2)
        {
            res = int.Parse(input[1..]);
        }
        else
        {
            res = int.Parse(input.Substring(input.Length - 2));
        }
        return input[0] == 'R' ? res : res * -1;
    }
    
    public override string Part1(string filename)
    {
        string input = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename));
        int res = 0;
        int acc = 50;
        foreach (string line in input.Split('\n'))
        {
            acc += ParseDial(line);

            if (acc > 99)
            {
                acc -= 100;
            }
            
            if (acc < 0)
            {
                acc += 100;
            }

            if (acc == 0)
            {
                res += 1;
            }

        }
        return res.ToString();
    }
    
    public override string Part2(string filename)
    {
        string input = Utils.InputReader.ReadAllLines(Path.Combine(InputFolder, filename));
        int res = 0;
        int acc = 50;
        foreach (string line in input.Split('\n'))
        {
            int move = ParseDial(line);
            int prevAcc = acc;
            acc += move;
            
            if (acc > 99)
            {
                acc -= 100;
            }
            
            if (acc < 0)
            {
                acc += 100;
            }

            if ((acc == 0) || (move < 0 && prevAcc <= acc && prevAcc != 0) || (move > 0 && prevAcc >= acc && prevAcc != 0))
            {
                res += 1;
            }

            int temp = int.Parse(line[1..]) / 100;
            res += temp % 10;
        }
        return res.ToString();
    }
}