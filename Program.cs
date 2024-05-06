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
            Console.WriteLine($"{line}");
        }
    }
}
