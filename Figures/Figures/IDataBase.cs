using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface IDataBase 
    {
        /// <summary>
        /// Sql Connection to Data Base
        /// </summary>
        SqlConnection Connection { get; }
        /// <summary>
        /// Add data to Data Base(insert)
        /// </summary>
        /// <param name="command">Sql query for insert data to table</param>
        /// <returns>Created Id in Data Base table</returns>
        int Add(string command);
        /// <summary>
        /// Get data from Data Base 
        /// </summary>
        /// <param name="command">Sql query for getting data from table </param>
        /// <returns>Data Set with selected data</returns>
        DataSet Select(string command);
        /// <summary>
        /// To update data in Data Base
        /// </summary>
        /// <param name="command">Sql query for updating</param>
        /// <returns>Quantity of updated rows</returns>
        int Update(string command);
        /// <summary>
        /// To delete some data in Data Base
        /// </summary>
        /// <param name="command">Sql query for deletion</param>
        /// <returns>Quantity of deleted rows</returns>
        int Delete(string command);

    }
}
