namespace EventStore.Persistence.SqlPersistence.SqlDialects
{
	public class PostgreSqlDialect : CommonSqlDialect
	{
		public override string InitializeStorage
		{
			get { return PostgreSqlStatements.InitializeStorage; }
		}

		public override string StreamId
		{
			get { return ":StreamId"; }
		}
		public override string StreamRevision
		{
			get { return ":StreamRevision"; }
		}
		public override string MaxStreamRevision
		{
			get { return ":MaxStreamRevision"; }
		}
		public override string Items
		{
			get { return ":Items"; }
		}
		public override string CommitId
		{
			get { return ":CommitId"; }
		}
		public override string CommitSequence
		{
			get { return ":CommitSequence"; }
		}
		public override string CommitStamp
		{
			get { return ":CommitStamp"; }
		}
		public override string CommitStampStart
		{
			get { return ":CommitStampStart"; }
		}
		public override string CommitStampEnd
		{
			get { return ":CommitStampEnd"; }
		}
		public override string Headers
		{
			get { return ":Headers"; }
		}
		public override string Payload
		{
			get { return ":Payload"; }
		}
		public override string Threshold
		{
			get { return ":Threshold"; }
		}

		public override string Limit
		{
			get { return ":Limit"; }
		}
		public override string Skip
		{
			get { return ":Skip"; }
		}

		public override string PurgeStorage
		{
			get { return PostgreSqlStatements.PurgeStorage; }
		}

		public override string GetCommitsFromStartingRevision
		{
			get { return PostgreSqlStatements.GetCommitsFromStartingRevision; }
		}

		public override string GetCommitsFromInstant
		{
			get { return PostgreSqlStatements.GetCommitsFromInstant; }
		}

		public override string GetCommitsFromToInstant
		{
			get { return PostgreSqlStatements.GetCommitsFromToInstant; }
		}

		public override string PersistCommit
		{
			get { return PostgreSqlStatements.PersistCommit; }
		}

		public override string DuplicateCommit
		{
			get { return PostgreSqlStatements.DuplicateCommit; }
		}

		public override string GetStreamsRequiringSnapshots
		{
			get { return PostgreSqlStatements.GetStreamsRequiringSnapshots; }
		}

		public override string GetSnapshot
		{
			get { return PostgreSqlStatements.GetSnapshot; }
		}

		public override string AppendSnapshotToCommit
		{
			get { return PostgreSqlStatements.AppendSnapshotToCommit; }
		}

		public override string MarkCommitAsDispatched
		{
			get { return PostgreSqlStatements.MarkCommitAsDispatched.Replace("1", "true"); }
		}

		public override string GetUndispatchedCommits
		{
			get { return PostgreSqlStatements.GetUndispatchedCommits.Replace("0", "false"); }
		}

		public override IDbStatement BuildStatement(System.Transactions.TransactionScope scope, System.Data.IDbConnection connection, System.Data.IDbTransaction transaction)
		{
			return new PgDbStatement(this, scope, connection, transaction);
		}
	}
}