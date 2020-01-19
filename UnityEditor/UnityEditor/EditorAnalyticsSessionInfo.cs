using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class EditorAnalyticsSessionInfo
{
    static public long activeElapsedTime { get; }
    static public long elapsedTime { get; }
    static public long focusedElapsedTime { get; }
    static public long id { get; }
    static public long playbackElapsedTime { get; }
    static public long sessionCount { get; }
    static public string userId { get; }

}

}
