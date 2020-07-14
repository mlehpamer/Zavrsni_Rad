using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacija_alata_za_modeliranje_BP
{
    class DataTypes
    {
        public bool FindDataType(string dataInput)
        {
            string newData = String.Empty;
            try
            {
                newData = dataInput.Substring(0, dataInput.IndexOf("("));
            }
            catch (ArgumentOutOfRangeException)
            {
                newData = dataInput;
                //throw new ObjectDisposedException("Invalid Input try again");
            }
            System.Console.WriteLine(newData);
            if (newData == "char")
                return Character(dataInput);
            if(newData == "varchar")
               return Varchar  (dataInput);
            if (newData == "binary" || newData == "varbinary")
                return Binary(dataInput);
            if (newData == "text" || newData=="blob")
                return Text(dataInput);
            if (newData == "bit")
                return Bit(dataInput);
            if (newData == "tinyint" || newData == "smallint" || newData=="mediumint" || newData == "int" || newData == "integer" || newData == "bigint")
               return  TinyInt(dataInput);
            if (newData == "float")
               return  Float(dataInput);
            if (newData == "double" || newData == "decimal")
                return Double(dataInput);
            return false;
        }
        private int FindDataLength(string dataInput)
        {
            string numberInString = string.Empty;
            int number = 0;
            for (int i = 0; i < dataInput.Length; i++)
            {
                if (Char.IsDigit(dataInput[i]) || dataInput[i]=='-')
                {
                    numberInString += dataInput[i];
                }
            }
            if (numberInString.Length > 0)
            {
                number = int.Parse(numberInString);
            }
            //System.Console.WriteLine(number.ToString());
            return number;
        }
        private bool Character(string dataInput)
        {
            if(FindDataLength(dataInput)<0 || FindDataLength(dataInput) > 255)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Varchar(string dataInput)
        {
            if (FindDataLength(dataInput) < 0 || FindDataLength(dataInput) > 65535)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Binary(string dataInput)
        {
            if(FindDataLength(dataInput)<0 || FindDataLength(dataInput) > 8000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Text(string dataInput)
        {
            if(FindDataLength(dataInput)<0 || FindDataLength(dataInput) > 65535)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Bit(string dataInput)
        {
            System.Console.Write("dsad");
            if (FindDataLength(dataInput) < 0 || FindDataLength(dataInput) > 64)
            {
                System.Console.Write("dfsdf");
                return false;
            }              
            else
                return true;
            
        }

        //TinyInt and SmallInt and MediumInt and Int and Integer and BigInt
        private bool TinyInt(string dataInput)
        {
            if (FindDataLength(dataInput) < 0 || FindDataLength(dataInput) > 255)
                return false;
            else
                return true;
        }

        private bool Float(string dataInput)
        {
            if (FindDataLength(dataInput) < 0 || FindDataLength(dataInput) > 53)
                return false;
            else
                return true;
        }

        //Double and Decimal
        private bool Double(string dataInput)
        {
            if (FindDataLength(dataInput) < 0 || FindDataLength(dataInput) > 64)
                return false;
            else
                return true;
        }
    }
}
