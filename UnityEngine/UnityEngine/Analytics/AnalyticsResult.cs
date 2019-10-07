using System;
using UnityEngine;

namespace UnityEngine.Analytics
{

public enum AnalyticsResult
{
    Ok = 0,
    NotInitialized = 1,
    AnalyticsDisabled = 2,
    TooManyItems = 3,
    SizeLimitReached = 4,
    TooManyRequests = 5,
    InvalidData = 6,
    UnsupportedPlatform = 7,
}

}
