using System;
using UnityEngine;

namespace UnityEngine.Analytics
{

public enum AnalyticsEventPriority
{
    FlushQueueFlag = 1,
    CacheImmediatelyFlag = 2,
    AllowInStopModeFlag = 4,
    SendImmediateFlag = 8,
    NormalPriorityEvent = 0,
    NormalPriorityEvent_WithCaching = 2,
    HighPriorityEvent = 1,
    HighPriorityEvent_InStopMode = 5,
    HighestPriorityEvent = 9,
}

}
