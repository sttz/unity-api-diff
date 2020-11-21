using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct ContentBuildProfileEvent
{
    public string Metadata;
    public string Name;
    public ulong TimeMicroseconds;
    public UnityEditor.Build.Content.ProfileEventType Type;

}

}
