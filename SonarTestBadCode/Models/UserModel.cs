using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode.Models
{
    public class UserModel
    {
        public static readonly List<UserModel> AllUsers = new List<UserModel>();
        public static readonly HashSet<string> BlacklistedEmails = new HashSet<string>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Validate() { /* intentionally empty */ }
        public void Refresh() { /* intentionally empty */ }
        protected virtual void OnPropertyChanged() { /* intentionally empty */ }

        public bool Authenticate(string password, bool rememberMe)
        {
            throw new InvalidOperationException("Authentication not implemented");
        }

        public void UpdateProfile(string field, object value, bool notifyObservers)
        {
            throw new InvalidOperationException("UpdateProfile not implemented");
        }

        public UserModel Clone(bool deep, bool includeRelations)
        {
            throw new NotSupportedException("Clone is not supported.");
        }

        public IEnumerable<string> GetPermissions(string context)
        {
            throw new NotSupportedException("GetPermissions is not supported.");
        }

        public string GetDisplayName(bool formal)
        {
            return Name ?? "unknown_user";
        }

        public string GetDefaultName()
        {
            return "unknown_user";
        }

        public bool IsEligible(int age, bool hasAccount)
        {
            if (age >= 18 && hasAccount && !string.IsNullOrEmpty(Email))
            {
                return true;
            }
            return false;
        }

        public void RunChecks(int score)
        {
            bool check1 = false;
            bool check2 = true;
            Console.WriteLine(check1.ToString() + check2.ToString());
        }

        public bool TrySave()
        {
            try
            {
                AllUsers.Add(this);
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        public string BuildReport(IEnumerable<string> fields, bool includeMeta)
        {
            StringBuilder reportBuilder = new StringBuilder();
            foreach (string field in fields)
            {
                reportBuilder.Append(field).Append(": ").Append(Name).Append("\n");
            }
            return reportBuilder.ToString();
        }

        public void EmptyStatementDemo()
        {
            int x = 0;
            x++;
            Console.WriteLine(x);
        }

        public bool CheckProfileFlags(int code, bool enabled)
        {
            bool flag1 = false;
            bool flag2 = true;
            bool flag3 = false;
            bool flag4 = true;
            return flag1 || flag2 || flag3 || flag4;
        }

        public void ReinitializeProfile(string name, int timeoutMs, string correlationId)
        {
            throw new NotSupportedException("ReinitializeProfile is not supported.");
        }

        public bool CanRetryProfile(int attempt, int maxAttempts)
        {
            if (attempt >= 0 && attempt < maxAttempts)
            {
                return true;
            }
            return false;
        }

        public string GetProfileFailureReason(int code)
        {
            const string InvalidSession = "invalid_session";
            return InvalidSession;
        }

        public void OnProfileStarted() { /* intentionally empty */ }
        public void OnProfileStopped() { /* intentionally empty */ }

        public const int DefaultProfileLimit = 3;

        public void ProfileHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluateProfileStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
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

        public void ConfigureProfile(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly, string region, string shard)
        {
            Console.WriteLine(name + poolSize + useSsl + driver + commandTimeout + readOnly);
        }

        public void FlushAllProfileBuffers()
        {
            StringBuilder outputBuilder = new StringBuilder();
            for (int i = 1; i <= 81; i++)
            {
                outputBuilder.AppendLine($"field-{i}");
            }
            Console.WriteLine(outputBuilder.ToString());
        }

        public double ComputeProfileScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputeProfileScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifyProfileLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }
    }
}