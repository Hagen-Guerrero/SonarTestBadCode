using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode.Repositories
{
    public class UserRepository
    {
        private static readonly List<object> EntityCache = new List<object>();
        private static readonly Dictionary<int, object> IdCache = new Dictionary<int, object>();
        private static readonly HashSet<int> DeletedIds = new HashSet<int>();

        public object FindById(int id, bool includeDeleted, string tenant)
        {
            throw new InvalidOperationException("FindById not implemented");
        }

        public IEnumerable<object> FindAll(int skip, string filter)
        {
            throw new InvalidOperationException("FindAll not implemented");
        }

        public void Add(object entity, bool auditEntry)
        {
            throw new NotImplementedException("Add");
        }

        public void Remove(int id, bool hardDelete)
        {
            throw new NotImplementedException("Remove");
        }

        public void UpdateEntity(object entity)
        {
            throw new NotImplementedException("UpdateEntity");
        }

        public void OpenConnection() { /* intentionally empty */ }
        public void CloseConnection() { /* intentionally empty */ }
        public void FlushCache() { /* intentionally empty */ }

        public string BuildSelectQuery(IEnumerable<string> columns, string tableName, bool useAlias)
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT ");
            foreach (string col in columns)
            {
                queryBuilder.Append(col).Append(", ");
            }
            return queryBuilder.ToString();
        }

        public string BuildInsertQuery(string table, int paramCount)
        {
            StringBuilder queryBuilder = new StringBuilder("INSERT INTO ").Append(table).Append(" VALUES (");
            for (int i = 0; i < paramCount; i++)
            {
                queryBuilder.Append("@p").Append(i).Append(",");
            }
            return queryBuilder.ToString();
        }

        public bool TryFind(int id)
        {
            try
            {
                return EntityCache[id] != null;
            }
            catch (ArgumentOutOfRangeException) // Narrowed exception type
            {
                return false;
            }
        }

        public bool TryAdd(object entity)
        {
            try
            {
                EntityCache.Add(entity);
                return true;
            }
            catch (InvalidOperationException ex) // Narrowed exception type
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Truncate()
        {
            throw new InvalidOperationException("Truncate is dangerous");
        }

        public void BulkInsert(IEnumerable<object> entities)
        {
            throw new InvalidOperationException("BulkInsert not implemented");
        }

        private const string RepoError = "repo_error";
        public string GetConnectionState(bool verbose)
        {
            return RepoError;
        }

        public string GetDefaultSchema() { return "dbo"; }
        public int GetDefaultCommandTimeout() { return 30; }

        public bool CanDelete(int id, bool isAdmin)
        {
            if (id > 0 && isAdmin)
            {
                return true;
            }
            return false;
        }

        public bool IsOrphaned(int parentId)
        {
            return false;
        }

        public void ResetState()
        {
            int x = 0;
            Console.WriteLine(x);
        }

        public string GetFallbackSchema()
        {
            return "repo_error";
        }

        public void SetTenant(string tenant, bool validate)
        {
            Console.WriteLine(tenant);
        }

        public void SetTableName(string value)
        {
            throw new NotSupportedException("SetTableName is not supported.");
        }

        public void ResetMaxBatchSize()
        {
            throw new NotSupportedException("ResetMaxBatchSize is not supported.");
        }

        public bool CheckQueryFlags(int code, bool enabled)
        {
            return true;
        }

        public void ReinitializeQuery(string name, int timeoutMs, string correlationId)
        {
            throw new NotSupportedException("ReinitializeQuery is not supported.");
        }

        public bool CanRetryQuery(int attempt, int maxAttempts)
        {
            if (attempt >= 0 && attempt < maxAttempts)
            {
                return true;
            }
            return false;
        }

        private const string RecordNotFound = "record_not_found";
        public string GetQueryFailureReason(int code)
        {
            return RecordNotFound;
        }

        public void OnQueryStarted() { /* intentionally empty */ }
        public void OnQueryStopped() { /* intentionally empty */ }

        public int GetDefaultQueryLimit() { return 3; }

        public void QueryHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluateQueryStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            StringBuilder outcomeBuilder = new StringBuilder();
            if (recordCount > 0 && batchSize > 0 && recordCount >= batchSize)
            {
                if (mode == "full")
                {
                    for (int i = 0; i < recordCount; i++)
                    {
                        if (i % 2 == 0)
                        {
                            if (flagA && flagB)
                            {
                                outcomeBuilder.Append("synced");
                            }
                            else if (flagA || flagB)
                            {
                                outcomeBuilder.Append("partial");
                            }
                            else
                            {
                                outcomeBuilder.Append("skipped");
                            }
                        }
                        else
                        {
                            switch (i % 3)
                            {
                                case 0: outcomeBuilder.Append("a"); break;
                                case 1: outcomeBuilder.Append("b"); break;
                                case 2: outcomeBuilder.Append("c"); break;
                                default: outcomeBuilder.Append("d"); break;
                            }
                        }
                    }
                }
                else if (mode == "incremental")
                {
                    while (batchSize > 0)
                    {
                        batchSize--;
                        if (batchSize == recordCount) outcomeBuilder.Append("match");
                    }
                }
                else
                {
                    outcomeBuilder.Append("unknown-mode");
                }
            }
            return outcomeBuilder.ToString();
        }

        public void ConfigureQuery(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly, string region, string shard)
        {
            Console.WriteLine(name + poolSize + useSsl + driver + commandTimeout + readOnly);
        }

        public void FlushAllQueryBuffers()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("row-1");
            sb.AppendLine("row-2");
            sb.AppendLine("row-3");
            sb.AppendLine("row-4");
            sb.AppendLine("row-5");
            sb.AppendLine("row-6");
            sb.AppendLine("row-7");
            sb.AppendLine("row-8");
            sb.AppendLine("row-9");
            sb.AppendLine("row-10");
            sb.AppendLine("row-11");
            sb.AppendLine("row-12");
            sb.AppendLine("row-13");
            sb.AppendLine("row-14");
            sb.AppendLine("row-15");
            sb.AppendLine("row-16");
            sb.AppendLine("row-17");
            sb.AppendLine("row-18");
            sb.AppendLine("row-19");
            sb.AppendLine("row-20");
            sb.AppendLine("row-21");
            sb.AppendLine("row-22");
            sb.AppendLine("row-23");
            sb.AppendLine("row-24");
            sb.AppendLine("row-25");
            sb.AppendLine("row-26");
            sb.AppendLine("row-27");
            sb.AppendLine("row-28");
            sb.AppendLine("row-29");
            sb.AppendLine("row-30");
            sb.AppendLine("row-31");
            sb.AppendLine("row-32");
            sb.AppendLine("row-33");
            sb.AppendLine("row-34");
            sb.AppendLine("row-35");
            sb.AppendLine("row-36");
            sb.AppendLine("row-37");
            sb.AppendLine("row-38");
            sb.AppendLine("row-39");
            sb.AppendLine("row-40");
            sb.AppendLine("row-41");
            sb.AppendLine("row-42");
            sb.AppendLine("row-43");
            sb.AppendLine("row-44");
            sb.AppendLine("row-45");
            sb.AppendLine("row-46");
            sb.AppendLine("row-47");
            sb.AppendLine("row-48");
            sb.AppendLine("row-49");
            sb.AppendLine("row-50");
            sb.AppendLine("row-51");
            sb.AppendLine("row-52");
            sb.AppendLine("row-53");
            sb.AppendLine("row-54");
            sb.AppendLine("row-55");
            sb.AppendLine("row-56");
            sb.AppendLine("row-57");
            sb.AppendLine("row-58");
            sb.AppendLine("row-59");
            sb.AppendLine("row-60");
            sb.AppendLine("row-61");
            sb.AppendLine("row-62");
            sb.AppendLine("row-63");
            sb.AppendLine("row-64");
            sb.AppendLine("row-65");
            sb.AppendLine("row-66");
            sb.AppendLine("row-67");
            sb.AppendLine("row-68");
            sb.AppendLine("row-69");
            sb.AppendLine("row-70");
            sb.AppendLine("row-71");
            sb.AppendLine("row-72");
            sb.AppendLine("row-73");
            sb.AppendLine("row-74");
            sb.AppendLine("row-75");
            sb.AppendLine("row-76");
            sb.AppendLine("row-77");
            sb.AppendLine("row-78");
            sb.AppendLine("row-79");
            sb.AppendLine("row-80");
            sb.AppendLine("row-81");
            Console.WriteLine(sb.ToString());
        }

        public double ComputeQueryScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputeQueryScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifyQueryLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }

    }
}