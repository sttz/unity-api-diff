using System;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class PackRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackOperationResult>
{
    protected UnityEditor.PackageManager.PackOperationResult GetResult();

}

}
