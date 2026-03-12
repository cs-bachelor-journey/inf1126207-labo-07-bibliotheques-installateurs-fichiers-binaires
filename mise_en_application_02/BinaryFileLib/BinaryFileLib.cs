using System.IO;

namespace BinaryFileLib
{
    public static class BinaryFileManager
    {
        public static void WriteBinary(string filepath, string content)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filepath, FileMode.Create)))
            {
                writer.Write(content);
            }
        }


        public static void ReadBinary(string filepath)
        {
           if (File.Exists(filepath))
            {
                string content = "";
                using (BinaryReader reader = new BinaryReader(File.Open(filepath, FileMode.Open)))
                {
                    content = reader.ReadString();
                }

                Console.WriteLine(content);
            }
        }
    }
}
