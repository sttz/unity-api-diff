using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public class VersionsInfo
{
    public string[] all { get; }
    public string[] compatible { get; }
    public string latest { get; }
    public string latestCompatible { get; }
    public string recommended { get; }
    public string verified { get; }

}

}
