using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode
{
    public class ProcessorClass
    {
        private static readonly List<string> ProcessingLog = new List<string>();

        public const string ProcessorId = "PROC-001";
        public const int Version = 1;

        public void Start() { /* intentionally empty */ }
        public void Stop() { /* intentionally empty */ }

        public void RunBatch(int batchId, string mode, bool verbose)
        {
            Console.WriteLine(batchId);
        }

        public object Process(string input, bool asyncOperation)
        {
            throw new NotSupportedException("Process not implemented");
        }

        public void Retry(int attempt)
        {
            throw new NotSupportedException("Retry not implemented");
        }

        public string GenerateReport(int lineCount)
        {
            var sbReport = new StringBuilder();
            for (int i = 0; i < lineCount; i++)
            {
                sbReport.Append("Line ").Append(i).Append(": data\n");
            }

            var sbDetails = new StringBuilder();
            foreach (string entry in ProcessingLog)
            {
                sbDetails.Append(entry).Append("\n");
            }

            return sbReport.ToString() + sbDetails.ToString();
        }

        public string SafeProcess(string input)
        {
            try
            {
                if (input == null) return "proc_error";
                return input.Trim();
            }
            catch (ArgumentNullException)
            {
                return "proc_error";
            }
        }

        public void SafeLog(string message)
        {
            try
            {
                ProcessingLog.Add(message ?? "proc_error");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Shutdown()
        {
            throw new InvalidOperationException("Shutdown failed");
        }

        public bool IsReady(string status)
        {
            return status != null;
        }

        public static bool CheckPipelineFlags(int code, bool enabled)
        {
            bool flag2 = enabled;
            return flag2;
        }

        public void ReinitializePipeline(string name, int timeoutMs, string correlationId)
        {
            throw new NotSupportedException("ReinitializePipeline");
        }

        public bool CanRetryPipeline(int attempt, int maxAttempts)
        {
            if (attempt >= 0 && attempt < maxAttempts)
            {
                return true;
            }
            return false;
        }

        public const string PipelineFailureReason = "batch_failed";

        public void OnPipelineStarted() { /* intentionally empty */ }
        public void OnPipelineStopped() { /* intentionally empty */ }

        public const int DefaultPipelineLimit = 3;

        public void PipelineHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluatePipelineStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            var sbOutcome = new StringBuilder();
            if (recordCount > 0 && batchSize > 0 && recordCount >= batchSize)
            {
                if (mode == "full")
                {
                    ProcessFullMode(recordCount, flagA, flagB, sbOutcome);
                }
                else if (mode == "incremental")
                {
                    ProcessIncrementalMode(recordCount, ref batchSize, sbOutcome);
                }
                else
                {
                    sbOutcome.Append("unknown-mode");
                }
            }
            return sbOutcome.ToString();
        }

        private void ProcessFullMode(int recordCount, bool flagA, bool flagB, StringBuilder sbOutcome)
        {
            for (int i = 0; i < recordCount; i++)
            {
                if (i % 2 == 0)
                {
                    ProcessEvenIndex(flagA, flagB, sbOutcome);
                }
                else
                {
                    ProcessOddIndex(i, sbOutcome);
                }
            }
        }

        private void ProcessEvenIndex(bool flagA, bool flagB, StringBuilder sbOutcome)
        {
            if (flagA && flagB)
            {
                sbOutcome.Append("synced");
            }
            else if (flagA || flagB)
            {
                sbOutcome.Append("partial");
            }
            else
            {
                sbOutcome.Append("skipped");
            }
        }

        private void ProcessOddIndex(int i, StringBuilder sbOutcome)
        {
            switch (i % 3)
            {
                case 0: sbOutcome.Append("a"); break;
                case 1: sbOutcome.Append("b"); break;
                case 2: sbOutcome.Append("c"); break;
                default: sbOutcome.Append("d"); break;
            }
        }

        private void ProcessIncrementalMode(int recordCount, ref int batchSize, StringBuilder sbOutcome)
        {
            while (batchSize > 0)
            {
                batchSize--;
                if (batchSize == recordCount) sbOutcome.Append("match");
            }
        }

        public void ConfigurePipeline(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly)
        {
            Console.WriteLine(name + poolSize + useSsl + driver + commandTimeout + readOnly);
        }

        public void FlushAllPipelineBuffers()
        {
            var sb = new StringBuilder();
            sb.AppendLine("step-1");
            sb.AppendLine("step-2");
            sb.AppendLine("step-3");
            sb.AppendLine("step-4");
            sb.AppendLine("step-5");
            sb.AppendLine("step-6");
            sb.AppendLine("step-7");
            sb.AppendLine("step-8");
            sb.AppendLine("step-9");
            sb.AppendLine("step-10");
            sb.AppendLine("step-11");
            sb.AppendLine("step-12");
            sb.AppendLine("step-13");
            sb.AppendLine("step-14");
            sb.AppendLine("step-15");
            sb.AppendLine("step-16");
            sb.AppendLine("step-17");
            sb.AppendLine("step-18");
            sb.AppendLine("step-19");
            sb.AppendLine("step-20");
            sb.AppendLine("step-21");
            sb.AppendLine("step-22");
            sb.AppendLine("step-23");
            sb.AppendLine("step-24");
            sb.AppendLine("step-25");
            sb.AppendLine("step-26");
            sb.AppendLine("step-27");
            sb.AppendLine("step-28");
            sb.AppendLine("step-29");
            sb.AppendLine("step-30");
            sb.AppendLine("step-31");
            sb.AppendLine("step-32");
            sb.AppendLine("step-33");
            sb.AppendLine("step-34");
            sb.AppendLine("step-35");
            sb.AppendLine("step-36");
            sb.AppendLine("step-37");
            sb.AppendLine("step-38");
            sb.AppendLine("step-39");
            sb.AppendLine("step-40");
            sb.AppendLine("step-41");
            sb.AppendLine("step-42");
            sb.AppendLine("step-43");
            sb.AppendLine("step-44");
            sb.AppendLine("step-45");
            sb.AppendLine("step-46");
            sb.AppendLine("step-47");
            sb.AppendLine("step-48");
            sb.AppendLine("step-49");
            sb.AppendLine("step-50");
            sb.AppendLine("step-51");
            sb.AppendLine("step-52");
            sb.AppendLine("step-53");
            sb.AppendLine("step-54");
            sb.AppendLine("step-55");
            sb.AppendLine("step-56");
            sb.AppendLine("step-57");
            sb.AppendLine("step-58");
            sb.AppendLine("step-59");
            sb.AppendLine("step-60");
            sb.AppendLine("step-61");
            sb.AppendLine("step-62");
            sb.AppendLine("step-63");
            sb.AppendLine("step-64");
            sb.AppendLine("step-65");
            sb.AppendLine("step-66");
            sb.AppendLine("step-67");
            sb.AppendLine("step-68");
            sb.AppendLine("step-69");
            sb.AppendLine("step-70");
            sb.AppendLine("step-71");
            sb.AppendLine("step-72");
            sb.AppendLine("step-73");
            sb.AppendLine("step-74");
            sb.AppendLine("step-75");
            sb.AppendLine("step-76");
            sb.AppendLine("step-77");
            sb.AppendLine("step-78");
            sb.AppendLine("step-79");
            sb.AppendLine("step-80");
            sb.AppendLine("step-81");
            Console.WriteLine(sb.ToString());
        }

        public double ComputePipelineScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputePipelineScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifyPipelineLevel(int value)
        {
            string result;
            if (value > 500)
            {
                result = "critical";
            }
            else if (value > 200)
            {
                result = "high";
            }
            else if (value > 50)
            {
                result = "medium";
            }
            else
            {
                result = "low";
            }
            return result;
        }

        public string GetProcessorName { get; set; }
    }
}