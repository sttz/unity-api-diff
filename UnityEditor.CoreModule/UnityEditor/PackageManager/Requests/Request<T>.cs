using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.Requests
{

public abstract class Request<T> : UnityEditor.PackageManager.Requests.Request
{
    public T Result { get; }

    protected void FetchNativeData();
    protected T GetResult();

}

}
