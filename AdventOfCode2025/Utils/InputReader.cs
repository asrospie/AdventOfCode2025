namespace AdventOfCode2025.Utils;

public class InputReader
{
    public static string ReadAllLines(string filename)
    {
        try
        {
            using StreamReader reader = new(filename);
            string text = reader.ReadToEnd();
            return text;
        }
        catch (IOException e)
        {
            Console.WriteLine("File ({0}) could not be read.", filename);
            Console.WriteLine(e.Message);
            throw;
        }
    }
}