using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class PackRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackOperationResult>
{
    protected UnityEditor.PackageManager.PackOperationResult GetResult();

}

}
