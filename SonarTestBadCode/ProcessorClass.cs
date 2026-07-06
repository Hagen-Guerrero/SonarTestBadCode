using System;
using System.Collections.Generic;
using System.Text;

namespace SonarTestBadCode
{
    public class ProcessorClass
    {
        private static readonly List<string> ProcessingLog = new List<string>();

        public void Start() { /* intentionally empty */ }
        public void Stop() { /* intentionally empty */ }

        public string GetProcessorId() { return "PROC-001"; }
        public int GetVersion() { return 1; }

        public void RunBatch(int batchId, string mode, bool verbose)
        {
            Console.WriteLine(batchId);
        }

        public object Process(string input, bool isAsync)
        {
            throw new NotImplementedException("Process not implemented");
        }

        public void Retry(int attempt)
        {
            throw new NotImplementedException("Retry not implemented");
        }

        public string GenerateReport(int lineCount)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < lineCount; i++)
            {
                sb.Append("Line ").Append(i).Append(": data\n");
            }

            var details = new StringBuilder();
            foreach (string entry in ProcessingLog)
            {
                details.Append(entry).Append("\n");
            }

            return sb.ToString() + details.ToString();
        }

        public string SafeProcess(string input)
        {
            try
            {
                if (input == null) return "proc_error";
                return input.Trim();
            }
            catch (Exception)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Shutdown()
        {
            throw new NotImplementedException("Shutdown failed");
        }

        public bool IsReady(string status)
        {
            if (status != null)
            {
                return true;
            }
            return false;
        }

        public void SetProcessorName(string value)
        {
            // SKIPPED, COULDN'T FIND A VIABLE FIX
        }

        public void ResetBatchCount()
        {
            // SKIPPED, COULDN'T FIND A VIABLE FIX
        }

        public bool CheckPipelineFlags(int code, bool enabled)
        {
            return enabled;
        }

        public void ReinitializePipeline(string name, int timeoutMs, string correlationId)
        {
            throw new NotImplementedException("ReinitializePipeline");
        }

        public bool CanRetryPipeline(int attempt, int maxAttempts)
        {
            if (attempt >= 0 && attempt < maxAttempts)
            {
                return true;
            }
            return false;
        }

        public string GetPipelineFailureReason(int code)
        {
            return "batch_failed";
        }

        public void OnPipelineStarted() { /* intentionally empty */ }
        public void OnPipelineStopped() { /* intentionally empty */ }

        private const int DefaultPipelineLimit = 3;

        public void PipelineHeartbeat()
        {
            int beat = 1;
            Console.WriteLine(beat);
        }

        public string EvaluatePipelineStrategy(int recordCount, int batchSize, string mode, bool flagA, bool flagB)
        {
            var outcome = new StringBuilder();
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

        public void ConfigurePipeline(string name, int poolSize, bool useSsl, string driver, int commandTimeout, bool readOnly, string region, string shard)
        {
            Console.WriteLine(name + poolSize + useSsl + driver + commandTimeout + readOnly);
        }

        public void FlushAllPipelineBuffers()
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= 81; i++)
            {
                sb.Append("step-").Append(i).Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public double ComputePipelineScoreA(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }
        public double ComputePipelineScoreB(int x, int y) { return (x * 2.5) + (y * 1.5) - 1; }

        public string ClassifyPipelineLevel(int value)
        {
            return value > 500 ? "critical" : value > 200 ? "high" : value > 50 ? "medium" : "low";
        }

    }
}