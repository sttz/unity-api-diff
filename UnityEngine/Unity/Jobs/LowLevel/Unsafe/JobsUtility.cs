using System;
using UnityEngine;

namespace Unity.Jobs.LowLevel.Unsafe
{

public static class JobsUtility
{
    static public int CacheLineSize = 64;
    static public int MaxJobThreadCount = 128;

    static public bool IsExecutingJob { get; }
    static public bool JobCompilerEnabled { get; set; }
    static public bool JobDebuggerEnabled { get; set; }
    static public int JobWorkerCount { get; set; }
    static public int JobWorkerMaximumCount { get; }

    static public IntPtr CreateJobReflectionData(Type type, Unity.Jobs.LowLevel.Unsafe.JobType jobType, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null);
    static public IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Unity.Jobs.LowLevel.Unsafe.JobType jobType, object managedJobFunction0);
    static public void GetJobRange(Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex);
    static public bool GetWorkStealingRange(Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex);
    static public void PatchBufferMinMaxRanges(IntPtr bufferRangePatchData, void jobdata, int startIndex, int rangeSize);
    static public void ResetJobWorkerCount();
    static public Unity.Jobs.JobHandle Schedule(JobScheduleParameters parameters);
    static public Unity.Jobs.JobHandle ScheduleParallelFor(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
    static public Unity.Jobs.JobHandle ScheduleParallelForDeferArraySize(JobScheduleParameters parameters, int innerloopBatchCount, void listData, void listDataAtomicSafetyHandle);
    static public Unity.Jobs.JobHandle ScheduleParallelForTransform(JobScheduleParameters parameters, IntPtr transfromAccesssArray);

    public struct JobScheduleParameters
    {
        public Unity.Jobs.JobHandle Dependency;
        public IntPtr JobDataPtr;
        public IntPtr ReflectionData;
        public int ScheduleMode;

        public JobScheduleParameters(void i_jobData, IntPtr i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode);

    }

}

}
