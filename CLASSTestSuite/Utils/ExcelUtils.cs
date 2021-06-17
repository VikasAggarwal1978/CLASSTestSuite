
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CLASSTestSuite.Utils
{
   public class ExcelUtils
    {
        public static Dictionary<string,string> GetExcelColumnData(string filePath, string columnName)
        {
            IExcelDataReader reader = null;
            Dictionary<string, string> data = new Dictionary<string, string>();
            string FilePath = @"C:\Users\vikas\source\repos\CLASSTestSuite\CLASSTestSuite\TestData\Test.xls";
            //Load file into a stream
            FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read);            
            reader = ExcelReaderFactory.CreateBinaryReader(stream);       
            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = false
                }
            };

            if (reader != null)
            {
                //Fill DataSet
                System.Data.DataSet result = reader.AsDataSet();
                DataTable table = result.Tables[0];

                foreach (DataColumn column in table.Columns)
                {
                    string cName = table.Rows[0][column.ColumnName].ToString();
                    if (!table.Columns.Contains(cName) && cName != "")
                    {
                        column.ColumnName = cName;
                    }

                }                
                foreach (DataRow row in table.Rows)
                    data.Add((string)row["field"], (string)row["data"]);
                
            }

            return data;
        }
    }
}
