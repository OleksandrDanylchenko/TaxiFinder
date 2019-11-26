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
                                                       ServicesNames = GetServicesNames()
                                                   });

        public string[] FilesPaths { get; private set; }
        public string[] ServicesNames { get; private set; }

        private static string[] GetFilesPaths()
        {
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dataPath = GetDataFolderPath(exePath);

            var filesPaths = Directory.GetFiles(dataPath, "*.xml", SearchOption.TopDirectoryOnly);
            return filesPaths;
        }

        private static string GetDataFolderPath(string exePath)
        {
            var dataPath = string.Empty;
            try
            {
                dataPath = Path.Combine(exePath ?? throw new ArgumentNullException(), "DataXML");
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, ".exe path null error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return dataPath;
        }

        private static string[] GetServicesNames()
        {
            var fileNames = GetFilesPaths()
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();
            return fileNames;
        }
    }
}