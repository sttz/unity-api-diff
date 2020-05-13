using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public class AsyncReadManagerMetricsFilters
{
    public AsyncReadManagerMetricsFilters();
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.Priority priorityLevel);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.Priority[] priorityLevels);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.FileReadType readType);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.FileReadType[] readTypes);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.ProcessingState state);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.ProcessingState[] states);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem);
    public AsyncReadManagerMetricsFilters(Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[] subsystems);
    public AsyncReadManagerMetricsFilters(ulong typeID);
    public AsyncReadManagerMetricsFilters(ulong[] typeIDs);
    public AsyncReadManagerMetricsFilters(ulong[] typeIDs, Unity.IO.LowLevel.Unsafe.ProcessingState[] states, Unity.IO.LowLevel.Unsafe.FileReadType[] readTypes, Unity.IO.LowLevel.Unsafe.Priority[] priorityLevels, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[] subsystems);

    public void ClearFilters();
    public void RemovePriorityFilter();
    public void RemoveReadTypeFilter();
    public void RemoveStateFilter();
    public void RemoveSubsystemFilter();
    public void RemoveTypeIDFilter();
    public void SetPriorityFilter(Unity.IO.LowLevel.Unsafe.Priority _priorityLevel);
    public void SetPriorityFilter(Unity.IO.LowLevel.Unsafe.Priority[] _priorityLevels);
    public void SetReadTypeFilter(Unity.IO.LowLevel.Unsafe.FileReadType _readType);
    public void SetReadTypeFilter(Unity.IO.LowLevel.Unsafe.FileReadType[] _readTypes);
    public void SetStateFilter(Unity.IO.LowLevel.Unsafe.ProcessingState _state);
    public void SetStateFilter(Unity.IO.LowLevel.Unsafe.ProcessingState[] _states);
    public void SetSubsystemFilter(Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem _subsystem);
    public void SetSubsystemFilter(Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[] _subsystems);
    public void SetTypeIDFilter(ulong _typeID);
    public void SetTypeIDFilter(ulong[] _typeIDs);

}

}
