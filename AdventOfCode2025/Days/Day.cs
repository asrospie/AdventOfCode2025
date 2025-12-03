namespace AdventOfCode2025.Days;

public abstract class Day
{
    protected string InputFolder { get; } = 
        Environment.GetEnvironmentVariable("INPUT_FOLDER") ?? 
        throw new FileNotFoundException("Input Folder not found.");
    
    public abstract string Part1(string input);
    public abstract string Part2(string input);

    // public Day(string[] partOneExamples, string partOneInput, string[] partTwoExamples, string partTwoInput)
    // {
    //      
    // }

    // public abstract void Run();
}