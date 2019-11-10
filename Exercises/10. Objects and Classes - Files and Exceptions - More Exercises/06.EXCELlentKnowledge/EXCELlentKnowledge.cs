using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

class EXCELlentKnowledge
{
    static void Main(string[] args)
    {
        Excel.Application xlApp = new Excel.Application();

        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\sample_table.xlsx");

        Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        Excel.Range xlRange = xlWorksheet.UsedRange;

        int rowCount = xlRange.Rows.Count;
        int colCount = xlRange.Columns.Count;

        for (int i = 1; i <= rowCount; i++)
        {
            for (int j = 1; j <= colCount; j++)
            {
                if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                {
                    Console.Write(xlRange.Cells[i, j].Value2.ToString() + "|");
                }
            }

            Console.WriteLine();
        }

        //cleanup
        GC.Collect();
        GC.WaitForPendingFinalizers();

        //rule of thumb for releasing com objects:
        //  never use two dots, all COM objects must be referenced and released individually
        //  ex: [somthing].[something].[something] is bad

        //release com objects to fully kill excel process from running in the background
        Marshal.ReleaseComObject(xlRange);
        Marshal.ReleaseComObject(xlWorksheet);

        //close and release
        xlWorkbook.Close();
        Marshal.ReleaseComObject(xlWorkbook);

        //quit and release
        xlApp.Quit();
        Marshal.ReleaseComObject(xlApp);
    }
}

//https://coderwall.com/p/app3ya/read-excel-file-in-c