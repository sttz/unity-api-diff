using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class AssetLoadInfo
{
    public string address { get; set; }
    public UnityEditor.GUID asset { get; set; }
    public System.Collections.Generic.List<UnityEditor.Build.Content.ObjectIdentifier> includedObjects { get; set; }
    public System.Collections.Generic.List<UnityEditor.Build.Content.ObjectIdentifier> referencedObjects { get; set; }

    public AssetLoadInfo();

}

}
