using System;
using UnityEngine;

namespace UnityEngine.Analytics
{

public class ContinuousEvent
{
    static public Analytics.AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled = true);
    static public Analytics.AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled = true, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult RegisterCollector(string metricName, Func<T> del);
    static public Analytics.AnalyticsResult SetCustomEventHistogramThresholds(string eventName, int count, T[] data);
    static public Analytics.AnalyticsResult SetEventHistogramThresholds(string eventName, int count, T[] data, int ver = 1, string prefix = "");

    public ContinuousEvent();

}

}
