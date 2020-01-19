using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Analytics
{

public enum AnalyticsEventPriority
{
    NormalPriorityEvent = 0,
    FlushQueueFlag = 1,
    HighPriorityEvent = 1,
    CacheImmediatelyFlag = 2,
    NormalPriorityEvent_WithCaching = 2,
    AllowInStopModeFlag = 4,
    HighPriorityEvent_InStopMode = 5,
    SendImmediateFlag = 8,
    HighestPriorityEvent = 9,
    NoCachingFlag = 16,
    NoRetryFlag = 32,
    NormalPriorityEvent_NoRetryNoCaching = 48,
    HighestPriorityEvent_NoRetryNoCaching = 49,
}

}
