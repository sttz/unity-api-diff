using System;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public abstract class Request : ISerializationCallbackReceiver
{
    public UnityEditor.PackageManager.Error Error { get; }
    public bool IsCompleted { get; }
    public UnityEditor.PackageManager.StatusCode Status { get; }

    protected void FetchNativeData();

}

}
