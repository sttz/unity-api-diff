using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public static class AsyncReadManagerMetrics
{
    static public void ClearCompletedMetrics();
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(Flags flags);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters metricsFilters, Flags flags);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric[] GetMetrics(Flags flags);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric[] GetMetrics(Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters filters, Flags flags);
    static public void GetMetrics(List<Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric> outMetrics, Flags flags);
    static public void GetMetrics(List<Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric> outMetrics, Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters filters, Flags flags);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric> metrics);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric[] metrics);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric> metrics, Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters metricsFilters);
    static public Unity.IO.LowLevel.Unsafe.AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric[] metrics, Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters metricsFilters);
    static public ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead);
    static public bool IsEnabled();
    static public void StartCollectingMetrics();
    static public void StopCollectingMetrics();

    public enum Flags
    {
        None = 0,
        ClearOnRead = 1,
    }

}

}
