using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class AddRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageInfo>
{
    protected UnityEditor.PackageManager.PackageInfo GetResult();

}

}
