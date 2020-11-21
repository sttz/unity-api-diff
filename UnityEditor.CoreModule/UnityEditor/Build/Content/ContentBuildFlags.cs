using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public enum ContentBuildFlags
{
    None = 0,
    DisableWriteTypeTree = 1,
    StripUnityVersion = 2,
    DevelopmentBuild = 4,
}

}
