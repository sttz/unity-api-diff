using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class SceneBundleInfo
{
    public string bundleName { get; set; }
    public List<UnityEditor.Build.Content.SceneLoadInfo> bundleScenes { get; set; }

    public SceneBundleInfo();

}

}
