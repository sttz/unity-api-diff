using System;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public sealed class EmbedRequest : UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageInfo>
{
    protected UnityEditor.PackageManager.PackageInfo GetResult();

}

}
