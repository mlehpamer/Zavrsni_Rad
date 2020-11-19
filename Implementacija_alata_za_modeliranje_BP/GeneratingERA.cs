using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Implementacija_alata_za_modeliranje_BP
{
    class GeneratingERA
    {
        public int NumberOfLinesInFile(string dirPath)
        {
            int lines=0;
            using (StreamReader sr = new StreamReader(dirPath))
            {
                while (sr.ReadLine() != null)
                {
                    lines++;
                }
                sr.Close();
            }
            return lines;
        }

        public List<String> AtributeNameAndTypeInFile(string dirPath)
        {
            List<string> atributeNameAndTypeInFile = new List<string>();
            using(StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if(parts[7].ToString()=="False" && parts[8]=="")
                        atributeNameAndTypeInFile.Add(parts[2] + "," + parts[3]);
                }
                sr.Close();
            }
            return atributeNameAndTypeInFile;
        }

        public List<String> ListOfFKAtributeAndType(string dirPath)
        {
            List<string> listOfFKAtributeAndType = new List<string>();

            using(StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[8].ToString() != "")
                    {
                        listOfFKAtributeAndType.Add(parts[2].ToString() + "," + parts[3].ToString());
                    }

                }
            }
            return listOfFKAtributeAndType;
        }

        public bool TableHasFK(string dirPath)
        {
            bool hasFK = false;
            using(StreamReader sr=new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[8] != "")
                    {                       
                        hasFK=true;
                    }

                }
                sr.Close();
            }
            return hasFK;
        }

        public int LengthOfNameAndType(string dirPath,string table)
        {
            int length=table.Substring(0,table.IndexOf('.')).Length;
            int newLength;
            using (StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {                    
                    string[] parts = line.Split(',');
                    newLength = parts[2].Length + parts[3].Length;
                    if (newLength > length)
                    {
                        length = newLength;
                        
                    }                    
                }
                sr.Close();
            }
            return length;
        }

        public int BiggestAttribute(string dirPath)
        {
            int length = 0;
            int newLength;
            using (StreamReader sr = new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    newLength = parts[2].Length;
                    if (newLength > length)
                    {
                        length = newLength;
                    }
                }
                sr.Close();
            }
            return length;
        }


        public List<String> ListOfPrimaryKeyInTable(string dirPath)
        {
            List<string> listOfPrimaryKeysForSpecificTable = new List<string>();

            using (StreamReader sr = new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[7].ToString() == "True")
                    {
                        listOfPrimaryKeysForSpecificTable.Add(parts[2].ToString() + "," + parts[3]);
                    }
                }
            }
            return listOfPrimaryKeysForSpecificTable;
        }
        
        public List<string> ListOfTableFK(string dirPath)
        {
            List<string> listOfTableFK = new List<string>();
            using(StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[8].ToString() != "")
                       listOfTableFK.Add(parts[8].Substring(parts[8].IndexOf("[")+1, parts[8].IndexOf(':')-1));
                }
                sr.Close();
            }
            return listOfTableFK;
        }

        public int NumberOfTables(string projectName)
        {
            LoadProjects loadProjects = new LoadProjects();
            return loadProjects.LoadTables(projectName).Count();
        }


        public List<int> BiggestTableWidthAndHeight(string projectPath, string projectName)
        {
            int biggestHeight = 0;
            int biggestWidth = 0;

            List<int> listOfAtributes = new List<int>();
            LoadProjects loadProjects = new LoadProjects();
            foreach (var table in loadProjects.LoadTables(projectName))
            {
                string tablePath = projectPath + "\\" + table;
                int height = (NumberOfLinesInFile(tablePath) * 15 + 17);
                int width = (LengthOfNameAndType(tablePath, table) * 8) + 46;
                if (height > biggestHeight) biggestHeight = height;
                if (width > biggestWidth) biggestWidth = width;
            }
            listOfAtributes.Add(biggestWidth);
            listOfAtributes.Add(biggestHeight);
            return listOfAtributes;
        }


        List<String> attributeName = new List<string>();
        bool LastAttribute(List<String> tableContent, int i)
        {
            if (i >= tableContent.Count)
            {
                return true;
            }
            return false;
        }
        int j = 0;
        public Dictionary<string,string> TypeOfConnection(string childTable, string parentTable,string projectPath)
        {
            LoadProjects loadProjects = new LoadProjects();
            List<string> contentOfChildTable = loadProjects.ListOfTableContent(projectPath + "\\" + childTable);
            Dictionary<string,string> listOFConnection= new Dictionary<string, string>();

            foreach (var attribute in contentOfChildTable)
            {
                string[] parts = attribute.Split(',');

                if (LastAttribute(contentOfChildTable, j))
                    attributeName.Clear();

                if (!attributeName.Contains(parts[2]))
                {
                    j = contentOfChildTable.IndexOf(attribute);

                    if (parts[8].Contains(parentTable) && parentTable + ".dat" == childTable)
                    {
                        if (parts[6].ToString() == "True" && parts[4].ToString() == "True")
                        {
                            listOFConnection.Add("1", "1");
                            attributeName.Add(parts[2].ToString());
                            break;
                        }
                        else
                        {
                            listOFConnection.Add("1", "M");
                            attributeName.Add(parts[2].ToString());
                            break;


                        }
                    }
                    else
                    {
                        //Ako atribut sadrzi ime primarne tablice onda provjeravamo taj atribut
                        if (parts[8].Contains(parentTable))
                        {
                            //Ako je unique onda je veza 1:1
                            if (parts[6].ToString() == "True")
                            {
                                listOFConnection.Add("1", "1");
                                attributeName.Add(parts[2].ToString());
                                break;


                            }
                            //Inace je veza 1:M
                            else
                            {
                                listOFConnection.Add("1", "M");
                                attributeName.Add(parts[2].ToString());
                                break;
                            }
                        }
                    }
                }
            }
            return listOFConnection;
        }


    }
}
