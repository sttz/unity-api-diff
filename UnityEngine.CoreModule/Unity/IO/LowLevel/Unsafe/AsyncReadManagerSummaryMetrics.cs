using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public class AsyncReadManagerSummaryMetrics
{
    public float AverageBandwidthMBPerSecond { get; }
    public float AverageReadSizeInBytes { get; }
    public float AverageReadTimeMicroseconds { get; }
    public float AverageThroughputMBPerSecond { get; }
    public float AverageTotalRequestTimeMicroseconds { get; }
    public float AverageWaitTimeMicroseconds { get; }
    public ulong LongestReadAssetType { get; }
    public Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem LongestReadSubsystem { get; }
    public float LongestReadTimeMicroseconds { get; }
    public ulong LongestWaitAssetType { get; }
    public Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem LongestWaitSubsystem { get; }
    public float LongestWaitTimeMicroseconds { get; }
    public int NumberOfAsyncReads { get; }
    public int NumberOfCachedReads { get; }
    public int NumberOfCanceledRequests { get; }
    public int NumberOfCompletedRequests { get; }
    public int NumberOfFailedRequests { get; }
    public int NumberOfInProgressRequests { get; }
    public int NumberOfSyncReads { get; }
    public int NumberOfWaitingRequests { get; }
    public ulong TotalBytesRead { get; }
    public int TotalNumberOfRequests { get; }

    public AsyncReadManagerSummaryMetrics();

}

}
