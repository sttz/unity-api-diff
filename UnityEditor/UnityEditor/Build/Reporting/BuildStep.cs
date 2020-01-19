using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public struct BuildStep
{
    public int depth { get; }
    public TimeSpan duration { get; }
    public UnityEditor.Build.Reporting.BuildStepMessage[] messages { get; }
    public string name { get; }

    public string ToString();

}

}
