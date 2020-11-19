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
        List<string> tempListOfProjects = new List<string>();

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
            try
            {
                string dirPath = CreateProjectDirectory() + "\\" + projectName;
                string[] subDirectories = Directory.GetFiles(dirPath);
                foreach (var item in subDirectories)
                {
                    string subFolder = item.Substring(item.LastIndexOf("\\") + 1);
                    listOfTables.Add(subFolder);
                }
            }
            catch { }
            return listOfTables;
        }

        public List<string> LoadTablesWithoutExtension(string projectName)
        {
            List<string> listOfTables = new List<string>();

            string dirPath = CreateProjectDirectory() + "\\" + projectName;
            string[] subDirectories = Directory.GetFiles(dirPath);
            foreach (var item in subDirectories)
            {
                string subFolder = item.Substring(item.LastIndexOf("\\") + 1);
                subFolder = subFolder.Substring(0, subFolder.LastIndexOf("."));
                listOfTables.Add(subFolder);
            }
            return listOfTables;
        }

        public List<String> OpenSpecificTable(string dirPath)
        {
            List<string> specificTableContent = new List<string>();
            using(StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string newLine=parts[2]+"," + parts[3] + "," + parts[4] + "," + parts[5] + "," + parts[7] + ","+parts[8]+",";
                    specificTableContent.Add(newLine);
                }
                sr.Close();
            }
            return specificTableContent;
        }

        public List<string> TempListOfProject(string projectName)
        {           
            tempListOfProjects.Add(projectName);
            return tempListOfProjects;
        }

        public void DeleteTableDependece(string projectName, string tableName)
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{dirPath}\Projects\"+projectName;
            string tableNameWithoutextension = tableName.Substring(0, tableName.IndexOf('.' ));
            foreach (var table in LoadTables(projectName))
            {              
                string tablePath = dirName + "\\" + table;
                List<string> tableContent = new List<string>();
                using (StreamReader sr=new StreamReader(tablePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[8].Contains(tableNameWithoutextension))
                        {
                            string newLine = "";
                            for(int i=0; i < parts.Length; i++)
                            {
                                if(i == 8){
                                    newLine += ",};";
                                }

                                else
                                {
                                    newLine += parts[i]+",";
                                }
                            }
                            tableContent.Add(newLine);
                        }
                        else
                        {
                            tableContent.Add(line);
                        }
                    }
                    sr.Close();
                    File.WriteAllLines(tablePath, tableContent.ToArray());
                    
                }
            }
        }

        public List<string> ListOfTableContent(string tablePath)
        {
            List<string> listOfTableContent = new List<string>();
            using(StreamReader sr= new StreamReader(tablePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listOfTableContent.Add(line);
                }
                sr.Close();
            }
            return listOfTableContent;
        }

        public List<String> TableContentToSQL(string projectName)
        {
            List<String> listOfTableContetn = new List<string>();
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{dirPath}\Projects\"+projectName;
            string databaseName = "CREATE DATABASE " + projectName+";";
            string newLine1 = "\n";
            listOfTableContetn.Add(databaseName);
            listOfTableContetn.Add(newLine1);

            foreach (var table in LoadTables(projectName))
            {
                string createNewTable = "CREATE TABLE " + table.Substring(0, table.IndexOf('.')) + "(";
                listOfTableContetn.Add(createNewTable);

                string tablePath = dirName + "\\" + table;
                //First Im looking for PK
                using (StreamReader sr = new StreamReader(tablePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = "";
                        string[] parts = line.Split(',');
                        if (parts[7] == "True")
                        {
                            newLine += parts[2] + " " + parts[3];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                if (parts[i] == "True")
                                {
                                    if (i == 4)
                                        newLine += " NOT NULL";
                                    if (i == 5)
                                        newLine += " AUTO INCREMENT";
                                    if (i == 6)
                                        newLine += " UNIQUE";
                                }
                            }
                            newLine += " PRIMARY KEY,";
                            listOfTableContetn.Add(newLine);
                        }
                    }
                    sr.Close();
                }

                //Here im looking for non PK or FK attributes
                using(StreamReader sr= new StreamReader(tablePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = "";
                        string[] parts = line.Split(',');
                        if (parts[7] == "False" && parts[8]=="")
                        {
                            newLine += parts[2] + " " + parts[3];
                            for (int i=0; i < parts.Length; i++)
                            {
                                if (parts[i] == "True")
                                {
                                    if (i == 4)
                                        newLine += " NOT NULL";
                                    if (i == 5)
                                        newLine += " AUTO INCREMENT";
                                    if (i == 6)
                                        newLine += " UNIQUE";
                                }
                            }
                            newLine += ",";

                            listOfTableContetn.Add(newLine);
                        }
                    }
                    sr.Close();
                }

                //Looking for attributes with FK
                using(StreamReader sr = new StreamReader(tablePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = "";
                        string[] parts = line.Split(',');
                        if (parts[8] != "")
                        {
                            string[] fkPart = parts[8].Split(':');
                            //System.Console.WriteLine(parts[8].ToString()+ "+"+ parts[2].ToString());
                            System.Console.WriteLine(fkPart[0].Substring(1, fkPart[0].IndexOf(':') + 1));

                            newLine += parts[2] + " " + parts[3] + " FOREIGN KEY REFERENCES " + fkPart[0].Substring(1, fkPart[0].Length-1) +"("+fkPart[1].Substring(0,fkPart[1].Length-3)+")";
                            for (int i = 0; i < parts.Length; i++)
                            {
                                if (parts[i] == "True")
                                {
                                    if (i == 4)
                                        newLine += " NOT NULL";
                                    if (i == 5)
                                        newLine += " AUTO INCREMENT";
                                    if (i == 6)
                                        newLine += " UNIQUE";
                                }
                            }
                            newLine += ",";

                            listOfTableContetn.Add(newLine);
                        }
                    }
                    sr.Close();
                }
                string end = ");";
                listOfTableContetn.Add(end);
                listOfTableContetn.Add(newLine1);
                          
            }
            return listOfTableContetn;         
        }
    }
}
