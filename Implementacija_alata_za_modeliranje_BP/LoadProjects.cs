using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Implementacija_alata_za_modeliranje_BP
{
    class LoadProjects
    {

        public List<String> ProjectList()
        {
            string dirPath = CreateProjectDirectory();
            string[] subDirectories = Directory.GetDirectories(dirPath);
            List<String> projectList = new List<string>();
            foreach (var item in subDirectories) 
            {
                string subFolder= item.Substring(item.LastIndexOf("\\")+1);
                projectList.Add(subFolder);
            }
            return projectList;
        }

        public string CreateProjectDirectory()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{dirPath}\Projects";
            if (!Directory.Exists(dirName))
            {
                DirectoryInfo di = Directory.CreateDirectory(dirName);
                return dirName;
            }
            return dirName;
        }

        public List<string> LoadTables(string projectName)
        {
            List<string> listOfTables = new List<string>();

            string dirPath = CreateProjectDirectory()+"\\"+projectName;
            string[] subDirectories = Directory.GetFiles(dirPath);
            foreach (var item in subDirectories)
            {
                string subFolder = item.Substring(item.LastIndexOf("\\") +1);
                listOfTables.Add(subFolder);
            }
            return listOfTables;
        }
    }
}
