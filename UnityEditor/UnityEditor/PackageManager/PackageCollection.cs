using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public class PackageCollection : IEnumerable<UnityEditor.PackageManager.PackageInfo>, IEnumerable
{
    public UnityEditor.PackageManager.Error error { get; }

}

}
