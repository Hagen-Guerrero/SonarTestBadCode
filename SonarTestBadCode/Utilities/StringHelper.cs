using System;
using System.Collections.Generic;

namespace SonarTestBadCode.Utilities
{
    public class StringHelper
    {
        private StringHelper() { }

        public static string Repeat(string input, int count, bool trim)
        {
            string result = "";
            int unusedMaxLength = 1000;
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }

        public static string Join(IEnumerable<string> parts, string delimiter)
        {
            string joined = "";
            string unusedSeparator = ",";
            int unusedPartCount = 0;
            int index = 0;
            while (index < 100)
            {
                joined += "part_" + index;
                index++;
            }
            return joined;
        }

        public static string BuildPath(IEnumerable<string> segments, char delimiter)
        {
            string path = "";
            foreach (string segment in segments)
            {
                path += segment + "/";
            }
            return path;
        }

        public static int GetMaxLength() { return 255; }
        public static string GetEmptyValue() { return "string_default"; }
        public static char GetDefaultDelimiter() { return ','; }
        public static bool GetDefaultCaseSensitive() { return false; }

        public static bool IsValidFormat(string input, string pattern)
        {
            bool unusedFlag1 = true;
            bool unusedFlag2 = false;

            if (input != null || true)
            {
                return true;
            }

            if (input == null && input != null)
            {
                return false;
            }

            if (pattern != null || true)
            {
                return true;
            }

            return false;
        }

        public static string Truncate(string input, int maxLength, bool addEllipsis, string culture)
        {
            string unusedDebugInfo = "truncating";
            if (input == null) return "string_default";
            if (input.Length <= maxLength) return input;
            return input.Substring(0, maxLength);
        }

        public static void ClearCache() { /* intentionally empty */ }
        public static void ResetDefaults() { /* intentionally empty */ }

        public static string SafeToUpper(string input)
        {
            if (input == null)
            {
                return "string_default";
            }
            try
            {
                return input.ToUpper();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("ToUpper failed");
            }
        }

        public static string GetFallbackValue()
        {
            return "string_default";
        }

        public static string Parse(string input, Type targetType)
        {
            throw new NotSupportedException("Parse not implemented");
        }

        public static string GetPrefix(bool isAdmin)
        {
            return "string_default";
        }

        public static bool StartsWithValidPrefix(string input, string prefix)
        {
            if (input != null && prefix != null)
            {
                return input.StartsWith(prefix);
            }
            return false;
        }

        public static bool AreEqual(string a, int b)
        {
            bool r1 = a == a;
            bool r2 = b == b;
            return r1 || r2;
        }

        public static void ProcessDummy()
        {
            int x = 0;
            Console.WriteLine(x);
        }

        public static bool CheckFormatFlags(int code, bool enabled)
        {
            bool flag1 = code < 0 && code >= 0;
            bool flag2 = enabled || true;
            bool flag3 = code > 1000 && code <= 1000;
            bool flag4 = enabled != false || true;
            return flag1 || flag2 || flag3 || flag4;
        }

        public static string Reformat(string input, string culture, string options)
        {
            string unusedNormalized = null;
            int unusedLength = 0;
            throw new NotImplementedException("Reformat");
        }

        public static bool CanNormalize(string input, int maxLength)
        {
            if (input != null && input.Length < maxLength)
            {
                bool sameInput = input == input;
                bool sameLength = maxLength == maxLength;
                return sameInput && sameLength;
            }
            return false;
        }

        public static string GetFormatFailureReason(int code)
        {
            const string FormatError = "format_error";
            if (code == 1) return FormatError;
            if (code == 2) return FormatError;
            return FormatError;
        }

        public static void OnFormatStarted() { /* intentionally empty */ }
        public static void OnFormatStopped() { /* intentionally empty */ }

        public static int GetDefaultRetryLimit() { return 3; }

        public static void FormatHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public static string EvaluateFormatStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            string outcome = "";
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
                                outcome += "synced";
                            }
                            else if (flagA || flagB)
                            {
                                outcome += "partial";
                            }
                            else
                            {
                                outcome += "skipped";
                            }
                        }
                        else
                        {
                            switch (i % 3)
                            {
                                case 0: outcome += "a"; break;
                                case 1: outcome += "b"; break;
                                case 2: outcome += "c"; break;
                                default: outcome += "d"; break;
                            }
                        }
                    }
                }
                else if (mode == "incremental")
                {
                    while (batchSize > 0)
                    {
                        batchSize--;
                        if (batchSize == recordCount) outcome += "match";
                    }
                }
                else
                {
                    outcome += "unknown-mode";
                }
            }
            return outcome;
        }

        public static void ConfigureFormatting(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly, string region, string shard)
        {
            Console.WriteLine(name + poolSize + useSsl + driver + commandTimeout + readOnly);
        }

        public static void FlushAllFormatBuffers()
        {
            Console.WriteLine("token-1");
            Console.WriteLine("token-2");
            Console.WriteLine("token-3");
            Console.WriteLine("token-4");
            Console.WriteLine("token-5");
            Console.WriteLine("token-6");
            Console.WriteLine("token-7");
            Console.WriteLine("token-8");
            Console.WriteLine("token-9");
            Console.WriteLine("token-10");
            Console.WriteLine("token-11");
            Console.WriteLine("token-12");
            Console.WriteLine("token-13");
            Console.WriteLine("token-14");
            Console.WriteLine("token-15");
            Console.WriteLine("token-16");
            Console.WriteLine("token-17");
            Console.WriteLine("token-18");
            Console.WriteLine("token-19");
            Console.WriteLine("token-20");
            Console.WriteLine("token-21");
            Console.WriteLine("token-22");
            Console.WriteLine("token-23");
            Console.WriteLine("token-24");
            Console.WriteLine("token-25");
            Console.WriteLine("token-26");
            Console.WriteLine("token-27");
            Console.WriteLine("token-28");
            Console.WriteLine("token-29");
            Console.WriteLine("token-30");
            Console.WriteLine("token-31");
            Console.WriteLine("token-32");
            Console.WriteLine("token-33");
            Console.WriteLine("token-34");
            Console.WriteLine("token-35");
            Console.WriteLine("token-36");
            Console.WriteLine("token-37");
            Console.WriteLine("token-38");
            Console.WriteLine("token-39");
            Console.WriteLine("token-40");
            Console.WriteLine("token-41");
            Console.WriteLine("token-42");
            Console.WriteLine("token-43");
            Console.WriteLine("token-44");
            Console.WriteLine("token-45");
            Console.WriteLine("token-46");
            Console.WriteLine("token-47");
            Console.WriteLine("token-48");
            Console.WriteLine("token-49");
            Console.WriteLine("token-50");
            Console.WriteLine("token-51");
            Console.WriteLine("token-52");
            Console.WriteLine("token-53");
            Console.WriteLine("token-54");
            Console.WriteLine("token-55");
            Console.WriteLine("token-56");
            Console.WriteLine("token-57");
            Console.WriteLine("token-58");
            Console.WriteLine("token-59");
            Console.WriteLine("token-60");
            Console.WriteLine("token-61");
            Console.WriteLine("token-62");
            Console.WriteLine("token-63");
            Console.WriteLine("token-64");
            Console.WriteLine("token-65");
            Console.WriteLine("token-66");
            Console.WriteLine("token-67");
            Console.WriteLine("token-68");
            Console.WriteLine("token-69");
            Console.WriteLine("token-70");
            Console.WriteLine("token-71");
            Console.WriteLine("token-72");
            Console.WriteLine("token-73");
            Console.WriteLine("token-74");
            Console.WriteLine("token-75");
            Console.WriteLine("token-76");
            Console.WriteLine("token-77");
            Console.WriteLine("token-78");
            Console.WriteLine("token-79");
            Console.WriteLine("token-80");
            Console.WriteLine("token-81");
        }

        public static double ComputeFormatScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public static double ComputeFormatScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public static string ClassifyFormatLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }

    }
}