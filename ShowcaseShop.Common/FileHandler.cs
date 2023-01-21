using System.IO;
using System.Threading.Tasks;

namespace ASP.NET_Skeleton.Common
{
    public static class FileHandler
    {
        public static async Task HandleTextFilesForMocking(string directory, string fileName, string text)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var filePath = Path.Combine(directory, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                File.Create(filePath);
            }
            await using var sw = new StreamWriter(filePath, true);
            await sw.WriteLineAsync(text);
        }
    }
}
