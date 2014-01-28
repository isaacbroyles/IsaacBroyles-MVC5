using System.IO;

namespace IsaacBroyles.Data
{
    public class TextFile
    {
        public TextFile(string path)
        {
            this.path = path;
        }

        public string Read()
        {
            using (var fileReader = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var textReader = new StreamReader(fileReader))
                {
                    return textReader.ReadToEnd();
                }
            }
        }

        private string path;
    }
}