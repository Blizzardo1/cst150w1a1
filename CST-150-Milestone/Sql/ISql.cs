namespace CST_150_Milestone.Sql
{
    public interface ISql
    {
        /// <summary>
        /// Inserts data into the specified table.
        /// </summary>
        /// <param name="table">The table to modify</param>
        /// <param name="data"><see cref="KeyValuePair{TKey,TValue}"/> to insert into <see cref="table"/></param>
        /// <remarks>The <see cref="data"/> parameter must match the table's structure else it will throw an error.</remarks>
        Task InsertInto(string table, Dictionary<string, dynamic> data);

        /// <summary>
        /// Updates given data to the specified <see cref="table"/>
        /// </summary>
        /// <param name="table">The table to modify</param>
        /// <param name="newData"><see cref="KeyValuePair{TKey,TValue}"/> to update in the <see cref="table"/></param>
        /// <param name="queryColumn">The query to use for WHERE</param>
        /// <param name="queryData">The data to use for WHERE</param>
        /// <remarks>The <see cref="newData"/> parameter must match whatever you are updating else it will throw an error.
        /// <see cref="queryColumn"/> and <see cref="queryData"/> refer to the WHERE clause such as 'WHERE <see cref="queryColumn"/>=<see cref="queryData"/>'
        /// </remarks>
        Task Update(string table, Dictionary<string, dynamic> newData, string queryColumn, dynamic queryData);

        /// <summary>
        /// Removes the element by <see cref="index"/> from the <see cref="table"/>
        /// </summary>
        /// <param name="table">The table to modify</param>
        /// <param name="index">The index of the element you want to remove</param>
        Task Delete(string table, int index);

        /// <summary>
        /// Removes the element by <see cref="query"/> from the <see cref="table"/>
        /// </summary>
        /// <param name="table">The table to modify</param>
        /// <param name="query">The query specification to select the element you want to remove</param>
        Task Delete(string table, string query);

        /// <summary>
        /// Opens a connection
        /// </summary>
        Task Connect();

        /// <summary>
        /// Closes the connection
        /// </summary>
        Task Disconnect();

    }
}
