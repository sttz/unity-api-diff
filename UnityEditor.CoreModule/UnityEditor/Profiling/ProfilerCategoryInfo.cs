using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public struct ProfilerCategoryInfo
{
    public Color32 color { get; }
    public Unity.Profiling.ProfilerCategoryFlags flags { get; }
    public ushort id { get; }
    public string name { get; }

}

}
