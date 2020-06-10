using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public class PackageRegistrationEventArgs
{
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.PackageManager.PackageInfo> added { get; private set; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.PackageManager.PackageInfo> changedFrom { get; private set; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.PackageManager.PackageInfo> changedTo { get; private set; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.PackageManager.PackageInfo> removed { get; private set; }

}

}
