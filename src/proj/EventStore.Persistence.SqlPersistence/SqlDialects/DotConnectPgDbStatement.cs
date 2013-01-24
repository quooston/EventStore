using System.Data;
using System.Transactions;
using Devart.Data.PostgreSql;

namespace EventStore.Persistence.SqlPersistence.SqlDialects
{
	public class DotConnectPgDbStatement : CommonDbStatement
	{
		public DotConnectPgDbStatement(ISqlDialect dialect, TransactionScope scope, IDbConnection connection, IDbTransaction transaction)
			: base(dialect, scope, connection, transaction)
		{ }

		protected override IDbCommand BuildCommand(string statement)
		{
			var cmd = base.BuildCommand(statement) as PgSqlCommand;
			if (cmd == null) throw new StorageException(Messages.CommandCreation);

			cmd.ParameterCheck = true;
			return cmd;
		}
	}
}