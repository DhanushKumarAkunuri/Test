namespace Test;

class Program
{
    static void Main(string[] args)
    {
        ReadInputFile("./input.txt");
    }

    static void ReadInputFile(string filePath)
    {
        foreach(var line in File.ReadLines(filePath))
        {
            Console.WriteLine($"{line} : {ToggleString(line)}");
        }
    }

    static string ToggleString(string s)
    {
        return new string(s.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
    }
}
