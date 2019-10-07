using System;
using UnityEngine;

namespace UnityEngine.WSA
{

public sealed class Application
{
    static public string advertisingIdentifier { get; }
    static public string arguments { get; }

    static public event WSA.WindowActivated windowActivated;
    static public event WSA.WindowSizeChanged windowSizeChanged;

    static public void InvokeOnAppThread(WSA.AppCallbackItem item, bool waitUntilDone);
    static public void InvokeOnUIThread(WSA.AppCallbackItem item, bool waitUntilDone);
    static public bool RunningOnAppThread();
    static public bool RunningOnUIThread();

    public Application();

}

}
