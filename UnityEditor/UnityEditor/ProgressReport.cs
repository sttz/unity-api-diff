using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ProgressReport
{
    public string description { get; internal set; }
    public string error { get; internal set; }
    public float progress { get; internal set; }

    public ProgressReport(float progress = -1, string description = null);

}

}
