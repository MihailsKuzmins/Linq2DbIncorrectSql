using LinqToDB.Mapping;

namespace Linq2DbIncorrectSql;

[Table("tblMyTable")]
public sealed record DatabaseEntryRecord
{
	[Column("colPK1", IsPrimaryKey = true, PrimaryKeyOrder = 1)]
	public int Id { get; init; }

	[Column("colPK2", IsPrimaryKey = true, PrimaryKeyOrder = 2)]
	public byte AnotherId { get; init; }

	[Column("number")]
	public int Number { get; init; }
}
