using LinqToDB;
using LinqToDB.Data;

namespace Linq2DbIncorrectSql;

internal sealed class Database : DataConnection
{
	public Database(string connectionString)
		: base("Microsoft.Data.SqlClient", connectionString)
	{
	}

	public ITable<DatabaseEntryRecord> Entries => this.GetTable<DatabaseEntryRecord>();
}
