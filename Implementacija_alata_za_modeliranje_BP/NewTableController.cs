using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Implementacija_alata_za_modeliranje_BP
{
    class NewTableController : DataTypes
    {
        public string ProvjeraImena(string name)
        {
            if (name.StartsWith(" "))
            {
                name = name.TrimStart();
            }

            if (name.Contains(" "))
                return name.Replace(" ", "_");
            else
                return name;
        }

        public bool CheckTextInput(string inputText)
        {
            var regexItem = new Regex("^[a-zA-Z0-9_ ]*$");
            if (inputText != "" && !Char.IsWhiteSpace(inputText[0]) && regexItem.IsMatch(inputText))
            {
                if (Char.IsDigit(inputText[0]))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private List<String> ListaTipova()
        {
            string text= "char(n);varchar(n);binary(n);varbinary(n);tinyblob;tinytext;text(n);blob(n);mediumtext;mediumblob;longtext; longblob;bit(n);tinyint(n);bool;boolean;smallint(n);mediumint(n);int(n);integer(n); bigint(n);float(n);double(n);decimal(n);date();datettime();timestamp();time();year();";
            List<String> listaTipova = new List<string>();
            string[] text2 = text.Split(';');
            foreach (var item in text2)
            {
                listaTipova.Add(item);
            }
            return listaTipova;
        }

        //Treba usporedit upisanu vriednost tipa podataka sa stvarnim podacima da se provjeri jel postoji. Trazi se pomocu stringa bez zagrada 
        public bool CheckDataType(string dataType)
        {
            List<String> listaTipova = new List<string>();
            listaTipova = ListaTipova();
            string textWithoutBrackets;
            foreach (var item in listaTipova)
            {
                try
                {
                    textWithoutBrackets = item.Substring(0, item.IndexOf("("));
                    if (dataType.Substring(0, dataType.IndexOf("(")) == textWithoutBrackets)
                    {
                        return FindDataType(dataType);
                    }
                }
                catch (Exception)
                {
                    textWithoutBrackets = item;
                    if (dataType == textWithoutBrackets)
                        return FindDataType(dataType);
                }
            }
            return false; ;
        }

        public void InsertDataIntoTextFile(string dirPath, int serialNumber, string atributName, string dataType, bool notNull, bool autoInc, bool unique, bool PK, string FK)
        {
            string lineInFile = serialNumber.ToString() + ",{," + atributName + "," + dataType + "," + notNull.ToString() + "," + autoInc.ToString() + "," + unique.ToString() + "," + PK.ToString() + "," + FK + ",};";
            using (StreamWriter sw = File.AppendText(dirPath))
            {
                sw.WriteLine(lineInFile);
                sw.Close();
            }                         
        }

        public bool CheckPrimaryKey(string dirPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(dirPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[7].ToString() == "True")
                        {
                            sr.Close();
                            return true;
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File can not be opened!");
            }
            return false;
        }

        public void DelteRowFromTable(int lineToDelete,string dirPath)
        {
                List<String> linesList = File.ReadAllLines(dirPath).ToList();
                linesList.RemoveAt(lineToDelete);
                File.WriteAllLines((dirPath), linesList.ToArray());          
        }

        public void DeleteTable(string dirPath)
        {
            File.Delete(dirPath);
        }

        public List <String> ListOfTableAtributesForPrimaryKey(string dirPath)
        {
            List<string> tableAtributes = new List<string>();

            try
            {
                using(StreamReader sr=new StreamReader(dirPath))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if(parts[3].Contains("int") && parts[7].ToString()!="True")
                            tableAtributes.Add(parts[2]);
                    }
                    sr.Close();
                }

            }catch(Exception e)
            {
            }
            return tableAtributes;
        }

        public bool CheckPrimaryKeyType(string dataType)
        {
            if (dataType.Contains("int") || dataType.Contains("char"))
            {
                return false;
            }
            else
            {
                return true ;
            }
        }

        public void CheckThoseDamnAtributesToPrimaryKeys(string atributName,string dirPath)
        {
            List<string> listOfAtributes = new List<string>();
            try
            {
                using (StreamReader sr=new StreamReader(dirPath))
                {
                    string line;                   
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');                       
                        if (parts[2] == atributName)
                        {
                            string newLine = "";
                            for (int i=0; i < parts.Length-1; i++)
                            {
                            if (i == 7 || i==4)
                            {
                                newLine += "True,";
                            }

                               else
                                newLine += parts[i]+",";
                            }
                            newLine += parts[parts.Length-1];
                            listOfAtributes.Add(newLine);
                        }
                        else
                        {
                            listOfAtributes.Add(line);

                        }
                    }
                    sr.Close();                   
                }
            }
            catch(Exception e)
             {
             }
            File.WriteAllLines(dirPath, listOfAtributes.ToArray());
        }


        public List<String> ListOfAtributesInCurrentTable(string dirPath)
        {
            List<string> listOfAtributesInCurrentTable = new List<string>();
            using(StreamReader sr=new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[7].ToString() != "True" && parts[8]=="")
                    {
                        listOfAtributesInCurrentTable.Add(parts[2].ToString());
                    }
                }
                sr.Close();
            }

            return listOfAtributesInCurrentTable;
        }

        public List<String> ListOfPrimaryKeysForSpecificTable(string dirPath)
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
                        listOfPrimaryKeysForSpecificTable.Add(parts[2].ToString());
                    }
                }
            }
            return listOfPrimaryKeysForSpecificTable;
        }

        public void InsertFKIntoFile(string dirPath, string atributName,string tableName, string PK)
        {
            List<string> listOfFileContent = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(dirPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[2].ToString() == atributName)
                        {
                            string newLine = null;
                            for(int i=0;i< parts.Length; i++)
                            {
                                if (i == 8)
                                {
                                    newLine += "[" + tableName + ":" + PK + "]";
                                }
                                else if(parts[i]=="};")
                                {
                                    newLine += "};";
                                    break;
                                }
                                else
                                {
                                    newLine += parts[i] + ",";
                                }
                            }
                            listOfFileContent.Add(newLine);
                        }
                        else
                        {
                            listOfFileContent.Add(line);
                        }
                    }
                    sr.Close();

                }
            }catch(Exception e)
            {
            }

            File.WriteAllLines(dirPath, listOfFileContent.ToArray());
        }

        public void DeleteForeignKey(string dirPath,string atributName)
        {
            List<String> linesList = File.ReadAllLines(dirPath).ToList();
            List<String> newList = new List<string>();
            using(StreamReader sr=new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine() )!= null)
                {
                    string[] parts = line.Split(',');
                    if (parts[2] == atributName)
                    {
                        string newLine=null;
                        for (int i=0; i < parts.Length; i++)
                        {
                            
                            if (i == 8)
                            {
                                newLine += ",";
                            }
                            else if (parts[i] == "};")
                            {
                                newLine += "};";
                                break;
                            }
                            else
                            {
                                 newLine += parts[i] + ",";
                            }
                        }
                        newList.Add(newLine);
                    }
                    else
                    {
                        newList.Add(line);
                    }
                    
                }
                sr.Close();
            }
            File.WriteAllLines(dirPath, newList.ToArray());
        }

        public bool CheckForSameAtributes(string dirPath, string atribut)
        {
            using(StreamReader sr= new StreamReader(dirPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[2] == atribut)
                    {
                        return false;
                    }
                }
                sr.Close();
            }
            return true;
        }

        public void ChangeFKNameInDatAfterRenaming(string oldName,string newName,string projectName, string projectPath)
        {
            LoadProjects loadProjects = new LoadProjects();
            List<String> listOfFileContent = new List<string>();

           

            foreach (var table in loadProjects.LoadTables(projectName))
            {
                listOfFileContent.Clear();
                string tablePath = projectPath + "\\" + table;
                
                using(StreamReader sr=new StreamReader(tablePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[8].Contains(oldName))
                        {
                            string newLine = null;
                            for(int i = 0; i < parts.Length; i++)
                            {
                                
                                if (i == 8)
                                {
                                    string [] secondPart = parts[8].Split(':');
                                    newLine += "["+newName+":"+secondPart[1];
                                }
                                else if (parts[i] == "};")
                                {
                                    newLine += "};";
                                    break;
                                }
                                else
                                {
                                    newLine += parts[i] + ",";
                                }
                            }
                            listOfFileContent.Add(newLine);
                        }
                        else
                        {
                            listOfFileContent.Add(line);
                        }
                    }
                    sr.Close();
                }
                File.WriteAllLines(tablePath, listOfFileContent.ToArray());
            }
        }



    }
}
