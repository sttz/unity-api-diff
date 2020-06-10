using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class ListRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageCollection>
{
    protected UnityEditor.PackageManager.PackageCollection GetResult();

}

}
