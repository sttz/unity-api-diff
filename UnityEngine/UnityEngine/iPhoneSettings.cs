using System;
using UnityEngine;

namespace UnityEngine
{

public class iPhoneSettings
{
    static public iPhoneGeneration generation { get; }
    static public iPhoneNetworkReachability internetReachability { get; }
    static public bool locationServiceEnabledByUser { get; }
    static public LocationServiceStatus locationServiceStatus { get; }
    static public string model { get; }
    static public string name { get; }
    static public bool screenCanDarken { get; }
    static public iPhoneScreenOrientation screenOrientation { get; }
    static public string systemName { get; }
    static public string systemVersion { get; }
    static public string uniqueIdentifier { get; }
    static public bool verticalOrientation { get; }

    static public void StartLocationServiceUpdates(float desiredAccuracyInMeters, float updateDistanceInMeters);
    static public void StartLocationServiceUpdates(float desiredAccuracyInMeters);
    static public void StartLocationServiceUpdates();
    static public void StopLocationServiceUpdates();

    public iPhoneSettings();

}

}
