using System;
using System.Collections;
using System.Collections.Generic;
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

}

}
