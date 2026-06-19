using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Core
{
    public class FileProvider
    {

        public static void Append(string fileName, string value)
        {
            using (var writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                writer.WriteLine(value);
            }
        }

        public static void Replace(string fileName, string value)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine(value);
            }
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static string GetValue(string fileName)
        {
            using (var reader = new StreamReader(fileName, Encoding.UTF8))
            {
                var value = reader.ReadToEnd();
                return value;
            }
        }

        public static void Clear(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }
}
