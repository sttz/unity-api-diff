using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct GestureErrorEventArgs
{
    public string error { get; private set; }
    public int hresult { get; private set; }

    public GestureErrorEventArgs(string error, int hresult);

}

}
