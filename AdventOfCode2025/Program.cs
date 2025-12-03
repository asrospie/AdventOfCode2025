using AdventOfCode2025.Days;
namespace AdventOfCode2025;

public static class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, Day> dayMap = new Dictionary<string, Day>();
        
        dayMap.Add("1", new Day01());
        dayMap.Add("2", new Day02());
        
        Console.WriteLine("Advent of Code 2025!");
        
        // Day one = new Day01();
        // Console.WriteLine("Day 1 Part 1: {0}", one.Part1("day1.example1.input"));
        // Console.WriteLine("Day 1 Part 1: {0}", one.Part1("day1.part1.input"));
        // Console.WriteLine("Day 1 Part 2: {0}", one.Part2("day1.example1.input"));
        // Console.WriteLine("Day 1 Part 2: {0}", one.Part2("day1.part1.input"));
        
        // Day two = new Day02();
        // Console.WriteLine("Day 2 Part 1: {0}", two.Part1("day2.example1.input"));
        // Console.WriteLine("Day 2 Part 1: {0}", two.Part1("day2.part1.input"));
        // Console.WriteLine("Day 2 Part 2: {0}", two.Part2("day2.example1.input"));
        // Console.WriteLine("Day 2 Part 2: {0}", two.Part2("day2.part1.input"));


        Day three = new Day03();
        Console.WriteLine("Day 3 Part 1: {0}", three.Part1("day3.example1.input"));
        Console.WriteLine("Day 3 Part 1: {0}", three.Part1("day3.part1.input"));
        Console.WriteLine("Day 3 Part 2: {0}", three.Part2("day3.example1.input"));
        Console.WriteLine("Day 3 Part 2: {0}", three.Part2("day3.part1.input"));
    }
}