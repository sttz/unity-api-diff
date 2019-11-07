using System;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class ListRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageCollection>
{
    protected UnityEditor.PackageManager.PackageCollection GetResult();

}

}
