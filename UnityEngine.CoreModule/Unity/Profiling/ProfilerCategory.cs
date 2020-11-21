using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling
{

public struct ProfilerCategory
{
    static public Unity.Profiling.ProfilerCategory Ai { get; }
    static public Unity.Profiling.ProfilerCategory Animation { get; }
    static public Unity.Profiling.ProfilerCategory Audio { get; }
    static public Unity.Profiling.ProfilerCategory Gui { get; }
    static public Unity.Profiling.ProfilerCategory Input { get; }
    static public Unity.Profiling.ProfilerCategory Internal { get; }
    static public Unity.Profiling.ProfilerCategory Lighting { get; }
    static public Unity.Profiling.ProfilerCategory Loading { get; }
    static public Unity.Profiling.ProfilerCategory Memory { get; }
    static public Unity.Profiling.ProfilerCategory Network { get; }
    static public Unity.Profiling.ProfilerCategory Particles { get; }
    static public Unity.Profiling.ProfilerCategory Physics { get; }
    static public Unity.Profiling.ProfilerCategory Render { get; }
    static public Unity.Profiling.ProfilerCategory Scripts { get; }
    static public Unity.Profiling.ProfilerCategory Video { get; }
    static public Unity.Profiling.ProfilerCategory VirtualTexturing { get; }
    static public Unity.Profiling.ProfilerCategory Vr { get; }

    public Color32 Color { get; }
    public string Name { get; }

    public ProfilerCategory(string categoryName);

    public string ToString();

}

}
