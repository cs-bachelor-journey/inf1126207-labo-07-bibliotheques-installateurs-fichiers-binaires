using BinaryFileLib;

class Program
{
    static void Main()
    {
        string path = "data.bin";

        Console.WriteLine("Enter a text to save in binary:");
        string text = Console.ReadLine();

        BinaryFileManager.WriteBinary(path, text);

        Console.WriteLine("Data saved in binary file.");

        Console.WriteLine("-------------------------------");
        Console.WriteLine("Data read from binary file:");
        BinaryFileManager.ReadBinary(path);
        
    }
}