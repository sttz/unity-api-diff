using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct BuildPlayerOptions
{
    public string assetBundleManifestPath { get; set; }
    public string locationPathName { get; set; }
    public UnityEditor.BuildOptions options { get; set; }
    public string[] scenes { get; set; }
    public UnityEditor.BuildTarget target { get; set; }
    public UnityEditor.BuildTargetGroup targetGroup { get; set; }

}

}
