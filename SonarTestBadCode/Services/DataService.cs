using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode.Services
{
    // ~74 SonarQube findings in this file
    public class DataService
    {
        private static readonly List<object> DataCache = new List<object>();
        private static readonly Queue<string> ProcessingQueue = new Queue<string>();

        private static readonly string _connectionString = null;

        public string LoadData(int count, string separator)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append("item_").Append(i);
            }
            return result.ToString();
        }

        public string ProcessItems(IEnumerable<string> items)
        {
            StringBuilder output = new StringBuilder();
            foreach (string item in items)
            {
                output.Append(item).Append(",");
            }
            return output.ToString();
        }

        public object GetById(int id, bool includeDeleted)
        {
            throw new InvalidOperationException("GetById not implemented");
        }

        public void Save(object entity, bool validateFirst)
        {
            throw new InvalidOperationException("Save not implemented");
        }

        public void DeleteById(int id)
        {
            throw new InvalidOperationException("Delete not implemented");
        }

        public IEnumerable<object> GetAll(int pageSize, string sortOrder)
        {
            throw new NotImplementedException("GetAll");
        }

        public void Update(object entity, bool merge)
        {
            throw new NotImplementedException("Update");
        }

        public IEnumerable<object> Search(string query, int maxResults)
        {
            throw new NotImplementedException("Search");
        }

        public void UpdateStatus(string status)
        {
            throw new NotImplementedException("UpdateStatus");
        }

        public void IncrementCounter()
        {
            throw new NotImplementedException("IncrementCounter");
        }

        public void BeginTransaction() { /* intentionally empty */ }
        public void CommitTransaction() { /* intentionally empty */ }
        public void RollbackTransaction() { /* intentionally empty */ }

        public object TryGet(int id)
        {
            try
            {
                return DataCache[id];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        public bool TrySave(object obj)
        {
            try
            {
                DataCache.Add(obj);
                return true;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private const string ServiceError = "service_error";

        public string GetStatusMessage(string code)
        {
            return ServiceError;
        }

        public string GetDisplayName(int type)
        {
            return ServiceError;
        }

        public bool IsValid(object obj, bool strict)
        {
            if (obj != null && strict)
            {
                return true;
            }
            return false;
        }

        public int GetDefaultTimeout() { return 30; }

        public void Execute(string command, int flags)
        {
            Console.WriteLine(command);
        }

        public void SetConnectionString(string value)
        {
            throw new NotImplementedException("SetConnectionString");
        }

        public void ResetRetryCount()
        {
            throw new NotImplementedException("ResetRetryCount");
        }

        public bool CheckSyncFlags(int code, bool enabled)
        {
            return true;
        }

        public void ReinitializeSync(string name, int timeoutMs, string correlationId)
        {
            throw new NotImplementedException("ReinitializeSync");
        }

        public bool CanRetrySync(int attempt, int maxAttempts)
        {
            if (attempt >= 0 && attempt < maxAttempts)
            {
                return true;
            }
            return false;
        }

        public string GetSyncFailureReason(int code)
        {
            return "connection_lost";
        }

        public void OnSyncStarted() { /* intentionally empty */ }
        public void OnSyncStopped() { /* intentionally empty */ }

        public int GetDefaultSyncLimit() { return 3; }

        public void SyncHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluateSyncStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            StringBuilder outcome = new StringBuilder();
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
                                outcome.Append("synced");
                            }
                            else if (flagA || flagB)
                            {
                                outcome.Append("partial");
                            }
                            else
                            {
                                outcome.Append("skipped");
                            }
                        }
                        else
                        {
                            switch (i % 3)
                            {
                                case 0: outcome.Append("a"); break;
                                case 1: outcome.Append("b"); break;
                                case 2: outcome.Append("c"); break;
                                default: outcome.Append("d"); break;
                            }
                        }
                    }
                }
                else if (mode == "incremental")
                {
                    while (batchSize > 0)
                    {
                        batchSize--;
                        if (batchSize == recordCount) outcome.Append("match");
                    }
                }
                else
                {
                    outcome.Append("unknown-mode");
                }
            }
            return outcome.ToString();
        }

        public void ConfigureSync(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly, string region, string shard)
        {
            StringBuilder output = new StringBuilder();
            output.Append(name).Append(poolSize).Append(useSsl).Append(driver).Append(commandTimeout).Append(readOnly);
            Console.WriteLine(output.ToString());
        }

        public void FlushAllSyncBuffers()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("buffer-1");
            output.AppendLine("buffer-2");
            output.AppendLine("buffer-3");
            output.AppendLine("buffer-4");
            output.AppendLine("buffer-5");
            output.AppendLine("buffer-6");
            output.AppendLine("buffer-7");
            output.AppendLine("buffer-8");
            output.AppendLine("buffer-9");
            output.AppendLine("buffer-10");
            output.AppendLine("buffer-11");
            output.AppendLine("buffer-12");
            output.AppendLine("buffer-13");
            output.AppendLine("buffer-14");
            output.AppendLine("buffer-15");
            output.AppendLine("buffer-16");
            output.AppendLine("buffer-17");
            output.AppendLine("buffer-18");
            output.AppendLine("buffer-19");
            output.AppendLine("buffer-20");
            output.AppendLine("buffer-21");
            output.AppendLine("buffer-22");
            output.AppendLine("buffer-23");
            output.AppendLine("buffer-24");
            output.AppendLine("buffer-25");
            output.AppendLine("buffer-26");
            output.AppendLine("buffer-27");
            output.AppendLine("buffer-28");
            output.AppendLine("buffer-29");
            output.AppendLine("buffer-30");
            output.AppendLine("buffer-31");
            output.AppendLine("buffer-32");
            output.AppendLine("buffer-33");
            output.AppendLine("buffer-34");
            output.AppendLine("buffer-35");
            output.AppendLine("buffer-36");
            output.AppendLine("buffer-37");
            output.AppendLine("buffer-38");
            output.AppendLine("buffer-39");
            output.AppendLine("buffer-40");
            output.AppendLine("buffer-41");
            output.AppendLine("buffer-42");
            output.AppendLine("buffer-43");
            output.AppendLine("buffer-44");
            output.AppendLine("buffer-45");
            output.AppendLine("buffer-46");
            output.AppendLine("buffer-47");
            output.AppendLine("buffer-48");
            output.AppendLine("buffer-49");
            output.AppendLine("buffer-50");
            output.AppendLine("buffer-51");
            output.AppendLine("buffer-52");
            output.AppendLine("buffer-53");
            output.AppendLine("buffer-54");
            output.AppendLine("buffer-55");
            output.AppendLine("buffer-56");
            output.AppendLine("buffer-57");
            output.AppendLine("buffer-58");
            output.AppendLine("buffer-59");
            output.AppendLine("buffer-60");
            output.AppendLine("buffer-61");
            output.AppendLine("buffer-62");
            output.AppendLine("buffer-63");
            output.AppendLine("buffer-64");
            output.AppendLine("buffer-65");
            output.AppendLine("buffer-66");
            output.AppendLine("buffer-67");
            output.AppendLine("buffer-68");
            output.AppendLine("buffer-69");
            output.AppendLine("buffer-70");
            output.AppendLine("buffer-71");
            output.AppendLine("buffer-72");
            output.AppendLine("buffer-73");
            output.AppendLine("buffer-74");
            output.AppendLine("buffer-75");
            output.AppendLine("buffer-76");
            output.AppendLine("buffer-77");
            output.AppendLine("buffer-78");
            output.AppendLine("buffer-79");
            output.AppendLine("buffer-80");
            output.AppendLine("buffer-81");
            Console.WriteLine(output.ToString());
        }

        public double ComputeSyncScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputeSyncScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifySyncLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }

    }
}