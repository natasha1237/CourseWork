namespace FiguresApp.Figures_Interfaces
{
    public interface IDataBase  // Basic operation C.R.U.D
    {
        /// <summary>
        /// Sql Connection to Data Base
        /// </summary>
        System.Data.SqlClient.SqlConnection GetConnection { get; }

        /// <summary>
        /// Add data to Data Base(insert)
        /// </summary>
        /// <param name="command">Sql query for insert data to table</param>
        /// <returns>Message w/ result</returns>
        string Add(string command);

        /// <summary>
        /// Get data from Data Base  
        /// </summary>
        /// <param name="command">Sql query for getting data from table </param>
        /// <returns>Data Set with selected data</returns>
        System.Data.DataSet Select(string command);

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