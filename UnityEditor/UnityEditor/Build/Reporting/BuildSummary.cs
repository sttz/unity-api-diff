using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public struct BuildSummary
{
    public DateTime buildEndedAt { get; }
    public DateTime buildStartedAt { get; }
    public UnityEditor.GUID guid { get; }
    public UnityEditor.BuildOptions options { get; }
    public string outputPath { get; }
    public UnityEditor.BuildTarget platform { get; }
    public UnityEditor.BuildTargetGroup platformGroup { get; }
    public UnityEditor.Build.Reporting.BuildResult result { get; }
    public int totalErrors { get; }
    public ulong totalSize { get; }
    public TimeSpan totalTime { get; }
    public int totalWarnings { get; }

}

}
