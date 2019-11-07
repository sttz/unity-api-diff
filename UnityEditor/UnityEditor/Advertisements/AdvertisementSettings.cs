using System;
using UnityEngine;

namespace UnityEditor.Advertisements
{

public static class AdvertisementSettings
{
    static public bool enabled { get; set; }
    static public bool initializeOnStartup { get; set; }
    static public bool testMode { get; set; }

    static public string GetGameId(RuntimePlatform platform);
    static public string GetPlatformGameId(string platformName);
    static public bool IsPlatformEnabled(RuntimePlatform platform);
    static public void SetGameId(RuntimePlatform platform, string gameId);
    static public void SetPlatformEnabled(RuntimePlatform platform, bool value);
    static public void SetPlatformGameId(string platformName, string gameId);

}

}
