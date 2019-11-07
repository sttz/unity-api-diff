using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class SceneBundleInfo
{
    public string bundleName { get; set; }
    public System.Collections.Generic.List<UnityEditor.Build.Content.SceneLoadInfo> bundleScenes { get; set; }

    public SceneBundleInfo();

}

}
