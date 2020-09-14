using Rodan.Business.Interfaces;
using System.IO;

namespace Rodan.Business.Managers
{
    public class FileManager : IFileManager
    {
        public string GetHtmlTemplate(string name)
        {
            string s = string.Empty;
            using (StreamReader reader = new StreamReader(Path.Combine("wwwroot/html", name)))
            {
                string row;
                while ((row = reader.ReadLine()) != null)
                    s += row;
            }
            return s;
        }
    }
}
