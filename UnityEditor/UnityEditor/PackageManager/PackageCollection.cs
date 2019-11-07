using System;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public class PackageCollection : System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo>, System.Collections.IEnumerable
{
    public UnityEditor.PackageManager.Error error { get; }

}

}
