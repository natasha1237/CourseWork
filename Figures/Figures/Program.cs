using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverName = "DESKTOP-LTPHR86", dbName = "Figures";
            Connection con = new Connection(serverName, dbName);

            Console.WriteLine(con.ConnectionString);
            Console.ReadKey();
        }
    }
}
