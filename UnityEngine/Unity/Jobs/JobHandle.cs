using System;
using UnityEngine;

namespace Unity.Jobs
{

public struct JobHandle
{
    static public bool CheckFenceIsDependencyOrDidSyncFence(Unity.Jobs.JobHandle jobHandle, Unity.Jobs.JobHandle dependsOn);
    static public Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
    static public Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2);
    static public Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
    static public Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs);
    static public void CompleteAll(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
    static public void CompleteAll(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2);
    static public void CompleteAll(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
    static public void ScheduleBatchedJobs();

    public bool IsCompleted { get; }

    public void Complete();

}

}
