using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class CrashReport
{
    static public CrashReport lastReport { get; }
    static public CrashReport[] reports { get; }

    static public void RemoveAll();

    public string text;
    public DateTime time;

    public void Remove();

}

}
