using System;
using UnityEngine;

namespace UnityEditor.Analytics
{

public static class AnalyticsSettings
{
    static public string configUrl { get; set; }
    static public bool deviceStatsEnabledInBuild { get; }
    static public bool enabled { get; set; }
    static public string eventUrl { get; set; }
    static public bool initializeOnStartup { get; set; }
    static public bool testMode { get; set; }

    static public event RequireInBuildDelegate OnRequireInBuildHandler;

    public delegate bool RequireInBuildDelegate();

}

}
