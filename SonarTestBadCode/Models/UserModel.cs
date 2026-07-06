using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode.Models
{
    public class UserModel
    {
        public static readonly List<UserModel> AllUsers = new List<UserModel>();
        public static readonly HashSet<string> BlacklistedEmails = new HashSet<string>();

        private static string _defaultRole = null;
        private static int _defaultAge = 0;

        private readonly string _unusedInternalNote;

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email { get; set; }

        public void Validate() { /* intentionally empty */ }
        public void Refresh() { /* intentionally empty */ }
        protected virtual void OnPropertyChanged() { /* intentionally empty */ }

        public bool Authenticate(string password, bool rememberMe)
        {
            throw new NotImplementedException("Authentication not implemented");
        }

        public void UpdateProfile(string field, object value, bool notifyObservers)
        {
            throw new NotImplementedException("UpdateProfile not implemented");
        }

        public UserModel Clone(bool deep, bool includeRelations)
        {
            throw new NotImplementedException("Clone");
        }

        public IEnumerable<string> GetPermissions(string context)
        {
            throw new NotImplementedException("GetPermissions");
        }

        public string GetDisplayName(bool formal)
        {
            const string UnknownUser = "unknown_user";
            return Name ?? UnknownUser;
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
            bool check1 = false; // Corrected from score > score
            bool check2 = true; // Corrected from score == score
            Console.WriteLine(check1.ToString() + check2.ToString());
        }

        public bool TrySave()
        {
            try
            {
                AllUsers.Add(this);
                return true;
            }
            catch (InvalidOperationException) // Narrowed exception type
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

        public static void SetDefaultRole(string value)
        {
            _defaultRole = value;
        }

        public static void ResetDefaultAge()
        {
            _defaultAge = 0;
        }

        public bool CheckProfileFlags(int code, bool enabled)
        {
            bool flag1 = false; // Corrected from code < 0 && code >= 0
            bool flag2 = true;
            bool flag3 = false; // Corrected from code > 1000 && code <= 1000
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
                bool sameAttempt = true; // Corrected from attempt == attempt
                bool sameMax = true; // Corrected from maxAttempts == maxAttempts
                return sameAttempt && sameMax;
            }
            return false;
        }

        public string GetProfileFailureReason(int code)
        {
            const string InvalidSession = "invalid_session";
            return InvalidSession; // Simplified identical branches
        }

        public void OnProfileStarted() { }
        public void OnProfileStopped() { }

        public const int DefaultProfileLimit = 3;

        public void ProfileHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluateProfileStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            StringBuilder outcomeBuilder = new StringBuilder();
            if (recordCount > 0)
            {
                if (batchSize > 0)
                {
                    if (recordCount >= batchSize)
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
            Console.WriteLine("field-1");
            Console.WriteLine("field-2");
            Console.WriteLine("field-3");
            Console.WriteLine("field-4");
            Console.WriteLine("field-5");
            Console.WriteLine("field-6");
            Console.WriteLine("field-7");
            Console.WriteLine("field-8");
            Console.WriteLine("field-9");
            Console.WriteLine("field-10");
            Console.WriteLine("field-11");
            Console.WriteLine("field-12");
            Console.WriteLine("field-13");
            Console.WriteLine("field-14");
            Console.WriteLine("field-15");
            Console.WriteLine("field-16");
            Console.WriteLine("field-17");
            Console.WriteLine("field-18");
            Console.WriteLine("field-19");
            Console.WriteLine("field-20");
            Console.WriteLine("field-21");
            Console.WriteLine("field-22");
            Console.WriteLine("field-23");
            Console.WriteLine("field-24");
            Console.WriteLine("field-25");
            Console.WriteLine("field-26");
            Console.WriteLine("field-27");
            Console.WriteLine("field-28");
            Console.WriteLine("field-29");
            Console.WriteLine("field-30");
            Console.WriteLine("field-31");
            Console.WriteLine("field-32");
            Console.WriteLine("field-33");
            Console.WriteLine("field-34");
            Console.WriteLine("field-35");
            Console.WriteLine("field-36");
            Console.WriteLine("field-37");
            Console.WriteLine("field-38");
            Console.WriteLine("field-39");
            Console.WriteLine("field-40");
            Console.WriteLine("field-41");
            Console.WriteLine("field-42");
            Console.WriteLine("field-43");
            Console.WriteLine("field-44");
            Console.WriteLine("field-45");
            Console.WriteLine("field-46");
            Console.WriteLine("field-47");
            Console.WriteLine("field-48");
            Console.WriteLine("field-49");
            Console.WriteLine("field-50");
            Console.WriteLine("field-51");
            Console.WriteLine("field-52");
            Console.WriteLine("field-53");
            Console.WriteLine("field-54");
            Console.WriteLine("field-55");
            Console.WriteLine("field-56");
            Console.WriteLine("field-57");
            Console.WriteLine("field-58");
            Console.WriteLine("field-59");
            Console.WriteLine("field-60");
            Console.WriteLine("field-61");
            Console.WriteLine("field-62");
            Console.WriteLine("field-63");
            Console.WriteLine("field-64");
            Console.WriteLine("field-65");
            Console.WriteLine("field-66");
            Console.WriteLine("field-67");
            Console.WriteLine("field-68");
            Console.WriteLine("field-69");
            Console.WriteLine("field-70");
            Console.WriteLine("field-71");
            Console.WriteLine("field-72");
            Console.WriteLine("field-73");
            Console.WriteLine("field-74");
            Console.WriteLine("field-75");
            Console.WriteLine("field-76");
            Console.WriteLine("field-77");
            Console.WriteLine("field-78");
            Console.WriteLine("field-79");
            Console.WriteLine("field-80");
            Console.WriteLine("field-81");
        }

        public double ComputeProfileScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputeProfileScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifyProfileLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }

    }
}