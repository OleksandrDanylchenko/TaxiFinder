using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal class FilesProvider
    {
        private FilesProvider() { }

        private static FilesProvider _instance;
        public static FilesProvider GetInstance => _instance ??
                                                   (_instance = new FilesProvider()
                                                   {
                                                       FilesPaths = GetFilesPaths(),
                                                       FilesNames = GetFilesNames()
                                                   });

        public string[] FilesPaths { get; private set; }
        public string[] FilesNames { get; private set; }

        private static string[] GetFilesPaths()
        {
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dataPath = GetDataPath(exePath);

            string[] filePaths = Directory.GetFiles(dataPath, "*.xml", SearchOption.TopDirectoryOnly);
            return filePaths;
        }

        private static string GetDataPath(string exePath)
        {
            string dataPath = string.Empty;
            try
            {
                dataPath = Path.Combine(exePath ?? throw new ArgumentNullException(), "DataXML");
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, ".exe path error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return dataPath;
        }

        private static string[] GetFilesNames()
        {
            string[] fileNames = GetFilesPaths()
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();
            return fileNames;
        }
    }
}