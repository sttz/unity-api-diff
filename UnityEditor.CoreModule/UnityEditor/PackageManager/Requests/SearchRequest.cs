using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class SearchRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageInfo[]>
{
    public string PackageIdOrName { get; }

    protected UnityEditor.PackageManager.PackageInfo[] GetResult();

}

}
