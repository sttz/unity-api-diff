using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Android
{

public class PermissionCallbacks : AndroidJavaProxy
{
    public event Action<string> PermissionDenied;
    public event Action<string> PermissionDeniedAndDontAskAgain;
    public event Action<string> PermissionGranted;

    public PermissionCallbacks();

}

}
