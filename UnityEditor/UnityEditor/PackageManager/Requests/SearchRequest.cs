using System;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class SearchRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageInfo[]>
{
    public string PackageIdOrName { get; }

    protected UnityEditor.PackageManager.PackageInfo[] GetResult();

}

}
