using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class SceneLoadInfo
{
    public string address { get; set; }
    public UnityEditor.GUID asset { get; set; }
    public string internalName { get; set; }

    public SceneLoadInfo();

}

}
