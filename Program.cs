using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LINQtoCSV;
using System.Globalization;
using EmployeeLibrary;



namespace MLassigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"D:\Csv formats\employeeinfo.csv";
            
            EmployeeProcessor Obj = new EmployeeProcessor();
            var Result= Obj.ReadCsvFile(filePath);
            Console.WriteLine(Result);
            Console.ReadLine();

        }
       
    }
}
