using System;
using UnityEngine;

namespace UnityEngine.iOS
{

public static class OnDemandResources
{
    static public bool enabled { get; }

    static public iOS.OnDemandResourcesRequest PreloadAsync(string[] tags);

}

}
