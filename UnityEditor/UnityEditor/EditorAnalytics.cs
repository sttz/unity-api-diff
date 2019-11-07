using System;
using UnityEngine;

namespace UnityEditor
{

public static class EditorAnalytics
{
    static public bool enabled { get; }

    static public Analytics.AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey);
    static public Analytics.AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver);
    static public Analytics.AnalyticsResult SendEventWithLimit(string eventName, object parameters);
    static public Analytics.AnalyticsResult SendEventWithLimit(string eventName, object parameters, int ver);
    static public Analytics.AnalyticsResult SetEventWithLimitEndPoint(string eventName, string endPoint, int ver);
    static public Analytics.AnalyticsResult SetEventWithLimitPriority(string eventName, Analytics.AnalyticsEventPriority eventPriority, int ver);

}

}
