using System;
using UnityEngine;

namespace UnityEditor.Scripting
{

public sealed class ManagedDebugger
{
    static public bool isAttached { get; }
    static public bool isEnabled { get; }

    static public event Action<bool> debuggerAttached;

    static public void Disconnect();

    public ManagedDebugger();

}

}
