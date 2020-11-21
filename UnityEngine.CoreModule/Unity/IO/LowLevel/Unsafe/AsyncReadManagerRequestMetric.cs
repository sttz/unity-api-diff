using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public struct AsyncReadManagerRequestMetric
{
    public string AssetName { get; }
    public ulong AssetTypeId { get; }
    public uint BatchReadCount { get; }
    public ulong CurrentBytesRead { get; }
    public string FileName { get; }
    public bool IsBatchRead { get; }
    public ulong OffsetBytes { get; }
    public Unity.IO.LowLevel.Unsafe.Priority PriorityLevel { get; }
    public Unity.IO.LowLevel.Unsafe.FileReadType ReadType { get; }
    public double RequestTimeMicroseconds { get; }
    public ulong SizeBytes { get; }
    public Unity.IO.LowLevel.Unsafe.ProcessingState State { get; }
    public Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Subsystem { get; }
    public double TimeInQueueMicroseconds { get; }
    public double TotalTimeMicroseconds { get; }

}

}
