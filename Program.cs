using Linq2DbIncorrectSql;
using LinqToDB;

LinqToDB.Data.DataConnection.TurnTraceSwitchOn();
LinqToDB.Data.DataConnection.WriteTraceLine = static (s1, s2, _) =>
{
	System.Diagnostics.Debug.WriteLine(s1, s2);
};

const string sqlServer = @"", database = "";
const string connectionString = @$"Data Source={sqlServer};Initial Catalog={database};Integrated Security=True;Trust Server Certificate=True";

await using var connection = new Database(connectionString);

await using var tmpTable = await connection.CreateTempTableAsync<DatabaseEntryRecord>("tmpTblName")
	.ConfigureAwait(false);

await connection.Entries
	.Where(x => x.Id == 1)
	.DeleteWithOutputIntoAsync(tmpTable)
	.ConfigureAwait(false);
