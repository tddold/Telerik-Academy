namespace Telerik_Academy_Youtube_RSS
{
    using System.IO;

    public static class Utility
    {
        public static string GetFileTextContent(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File dose not exist. File name: " + filePath);
            }

            string textContent = string.Empty;

            using (var reader = new StreamReader(filePath))
            {
                textContent = reader.ReadToEnd();
            }

            return textContent;
        }
    }
}
