using System;

using System.Collections.Generic;

using System.Text;

using System.IO;
using OfficeOpenXml;

namespace ConsoleUnitTest_BulkInsert
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (Stream s =  new FileStream(@".\\Key Valuations Export (1).xlsx",FileMode.Open))
            {
                ExcelPackage e = new ExcelPackage(s);

                
                BulkUploadToSql myData =  BulkUploadToSql.Load(e);
                myData.Flush(10);

                //myData.Flush();

            }

        }
    }
}
