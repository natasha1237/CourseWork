using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void PrintDataset(DataSet dataset)
        {
            foreach (var col in dataset.Tables[0].Columns)
            {
                Console.Write(col + "\t");
            }
            Console.WriteLine();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                foreach (var obj in row.ItemArray)
                {
                    Console.Write(obj + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string serverName = "DESKTOP-LTPHR86", dbName = "Figures";
            DataBase db = new DataBase(serverName, dbName);
            string comm = "select name, size from parameters2d";
            DataSet ds = db.Select(comm);
            PrintDataset(ds);
            string ins = "insert into parameters2d (name, size) values ('B', 23) ";

            int idIns = db.Add(ins);
            db.Add(ins);
            IPrinter printer = new PrinterConsole();
            int[] a = new int[2] { 1, 2 };
            printer.Print();
            Console.ReadKey();
        }
    }
}
