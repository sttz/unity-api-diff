using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Analytics
{

public static class AnalyticsSessionInfo
{
    static public string customDeviceId { get; set; }
    static public string customUserId { get; set; }
    static public string identityToken { get; }
    static public long sessionCount { get; }
    static public long sessionElapsedTime { get; }
    static public bool sessionFirstRun { get; }
    static public long sessionId { get; }
    static public Analytics.AnalyticsSessionState sessionState { get; }
    static public string userId { get; }

    static public event IdentityTokenChanged identityTokenChanged;
    static public event SessionStateChanged sessionStateChanged;

    public delegate void IdentityTokenChanged(string token);

    public delegate void SessionStateChanged(Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);

}

}
