using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Analytics
{

public class ContinuousEvent
{
    static public Analytics.AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled = true);
    static public Analytics.AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled = true, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult RegisterCollector<T>(string metricName, Func<T> del);
    static public Analytics.AnalyticsResult SetCustomEventHistogramThresholds<T>(string eventName, int count, T[] data);
    static public Analytics.AnalyticsResult SetEventHistogramThresholds<T>(string eventName, int count, T[] data, int ver = 1, string prefix = "");

    public ContinuousEvent();

}

}
