using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class OnDemandResourcesRequest : AsyncOperation, IDisposable
{
    public string error { get; }
    public float loadingPriority { get; set; }

    public void Dispose();
    public string GetResourcePath(string resourceName);

}

}
