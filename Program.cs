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

    static string ToggleString(string input)
    {
        if(input.Length < 100)
            return new string(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        else
        {
            char[] output = input.ToCharArray();
            Parallel.For(0, output.Length, i => {
                if(char.IsLower(output[i]))
                    output[i] = char.ToUpper(output[i]);
                else
                    output[i] = char.ToLower(output[i]);
            });
            return new string(output);
        }
    }
}
