using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;

namespace CST_150_Milestone.Sql
{
    internal class Sql : ISql
    {
        private readonly SQLiteConnection _con;
        private readonly string table;
        private StringBuilder _log;

        public string Log => _log.ToString();

        public Sql(string table)
        {
            _log = new();
            _con = new(@$"URI=file:{Program.DbPath}");

            this.table = table;
            if (!File.Exists(Program.DbPath))
                CreateDatabase(table);

        }

        private async void CreateDatabase(string table)
        {

            string cmd = @$"CREATE TABLE {table}(id INTEGER PRIMARY KEY,
                           name VARCHAR(256),
                           birthdate  LONG,
                           emailaddress TEXT,
                           studentid INT,
                           birthplace TEXT,
                           gradepointaverage DECIMAL,
                           profilepicture TEXT,
                           notes TEXT);";

            await Connect();
            await Execute(cmd);
        }

        // TODO: This breaks for some reason near my name
        // Likely because the strings are not encapsulated
        private async Task<int> Execute(string query)
        {
            _log.AppendLine($"Execute: {query}");
#if !DRYRUN
            var cmd = new SQLiteCommand(query, _con);
            return await cmd.ExecuteNonQueryAsync();
#else
            _log.Info($"DRY: {query}");
            await Task.CompletedTask;
            return 0;
#endif
        }

        /// <summary>
        /// Creates a new reader of the data specified by the <see cref="query"/>
        /// </summary>
        /// <param name="query">The MYSQL Query to send to the server</param>
        /// <returns>A new <see cref="DbDataReader"/></returns>
        private async Task<DbDataReader> ExecuteReader(string query)
        {
            var cmd = new SQLiteCommand(query, _con);
            return await cmd.ExecuteReaderAsync();
        }

        #region Implementation of ISql

        /// <inheritdoc />
        public async Task InsertInto(string table, Dictionary<string, dynamic> data)
        {
            await
                Execute($"INSERT INTO {table} ({data.Keys.Aggregate((x, y) => $"{x}, {y}")}) VALUES ({data.Values.Aggregate((x, y) => $"{x}, {y}")})");
        }

        public async Task InsertInto(Dictionary<string, dynamic> data) => await InsertInto(table, data);


        /// <inheritdoc />
        public async Task Update(string table, Dictionary<string, object> newData, string queryColumn, dynamic queryValue)
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<string, dynamic> k in newData)
            {

                sb.Append(long.TryParse(Convert.ToString(k.Value), out long v)
                              ? $"{k.Key}={v},"
                              : $"{k.Key}={k.Value},");
            }
            string query =
                $"UPDATE {table} set {sb.ToString().TrimEnd(",".ToCharArray())} WHERE {queryColumn}={queryValue}";
            await Execute(query);
        }
        public async Task Update(Dictionary<string, object> newData, string queryColumn, dynamic queryValue) => await Update(table, newData, queryColumn, queryValue);

        /// <inheritdoc />
        public async Task Delete(string table, int index)
        {
            await Delete(table, $"INDEX = `{index}`");
        }

        public async Task Delete(int index) => await Delete(table, index);

        /// <inheritdoc />
        public async Task Delete(string table, string query)
        {
            await Execute($"DELETE FROM `{table}` WHERE {query};");
        }

        public async Task Delete(string queryColumn, dynamic queryValue) => await Delete(table: table, $"`{queryColumn}`={queryValue}");

        public async Task Delete(string query) => await Delete(query);


        public async Task<bool> Exists(string table, string column, dynamic entry)
        {
            bool ret = false;
            DbDataReader reader = await ExecuteReader($"SELECT * FROM `{table}` WHERE `{column}`='{entry}'");
            while (await reader.ReadAsync())
            {
                dynamic ts = await reader.GetFieldValueAsync<dynamic>(0);
                ret = ts != null;
                break;
            }

            reader.Close();
            return ret;
        }

        public async Task<bool> Exists(string column, dynamic entry) => await Exists(table, column, entry);

        /// <inheritdoc />
        public async Task Connect()
        {
            await _con.OpenAsync();
        }

        /// <inheritdoc />
        public async Task Disconnect()
        {
            await _con.CloseAsync();
        }

        #endregion

        // ReSharper disable CS8625
        public async Task<List<object>> GetEntry(string table, string column, string queryColumn = "",
                                                       dynamic queryValue = default)
        {
            if (_con.State != ConnectionState.Open)
                throw new SQLiteException("Database not connected!");

            string query = queryColumn.IsEmpty()
                ? $"SELECT {column} from `{table}`"
                : $"SELECT {column} from `{table}` where `{queryColumn}`='{queryValue}'";

            DbDataReader reader = await ExecuteReader(query);

            List<object> lst = new();
            while (await reader.ReadAsync())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                lst.Add(values);
            }
            reader.Close();
            return lst;
        }
        public async Task<List<object>> GetEntry(string column, string queryColumn = "",
                                                       dynamic queryValue = default) => await GetEntry(table, column, queryColumn, queryValue);
    }
}
