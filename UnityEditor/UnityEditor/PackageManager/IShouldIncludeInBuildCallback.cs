using System;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public interface IShouldIncludeInBuildCallback
{
    public string PackageName { get; }

    public bool ShouldIncludeInBuild(string path);

}

}
