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

        public List<String> projectList()
        {
            string[] subdirectories = Directory.GetDirectories(@"C:\Users\Mihael\Desktop\IS\Zaršni rad\Implementacija_alata_za_modeliranje_BP\Implementacija_alata_za_modeliranje_BP\Projects");
            List<String> projectList = new List<string>();
            foreach (var item in subdirectories) 
            {
                string subFolder= item.Substring(item.LastIndexOf("\\")+1);
                projectList.Add(subFolder);
                //Console.WriteLine(subFolder.ToString());
            }
            return projectList;
        }
    }
}
