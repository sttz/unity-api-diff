using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class AssetLoadInfo
{
    public string address { get; set; }
    public UnityEditor.GUID asset { get; set; }
    public List<UnityEditor.Build.Content.ObjectIdentifier> includedObjects { get; set; }
    public List<UnityEditor.Build.Content.ObjectIdentifier> referencedObjects { get; set; }

    public AssetLoadInfo();

}

}
