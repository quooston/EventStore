namespace EventStore.Persistence.SqlPersistence.SqlDialects
{
	public class PostgreSqlDialect : CommonSqlDialect
	{
		public override string InitializeStorage
		{
			get { return PostgreSqlStatements.InitializeStorage; }
		}

		public override IDbStatement BuildStatement(System.Transactions.TransactionScope scope, System.Data.IDbConnection connection, System.Data.IDbTransaction transaction)
		{
			return new DotConnectPgDbStatement(this, scope, connection, transaction);
		}

		public override string MarkCommitAsDispatched
		{
			get { return base.MarkCommitAsDispatched.Replace("1", "true"); }
		}
		public override string GetUndispatchedCommits
		{
			get { return base.GetUndispatchedCommits.Replace("0", "false"); }
		}
	}
}