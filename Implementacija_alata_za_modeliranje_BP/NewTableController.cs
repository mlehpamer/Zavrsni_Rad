﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Implementacija_alata_za_modeliranje_BP
{
    class NewTableController :DataTypes
    {
        public string ProvjeraImena(string name)
        {
            if(name.StartsWith(" "))
            {
                name= name.TrimStart();
            }

            if (name.Contains(" "))
                return name.Replace(" ","_");
            else
                return name;
        }

        public bool CheckName(string name)
        {
            if(name==" ")
            {
                return false;
            }
            else
            {
                if (Char.IsDigit(name, 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool CheckTextInput(string inputText)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
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
             string text = System.IO.File.ReadAllText(@"C:\Users\Mihael\Desktop\IS\Zaršni rad\Implementacija_alata_za_modeliranje_BP\Implementacija_alata_za_modeliranje_BP\Text files\DataTypes.txt");
            List<String> listaTipova= new List<string>();
            string [] text2= text.Split(';');
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
    }
}
