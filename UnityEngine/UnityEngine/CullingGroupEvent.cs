using System;
using UnityEngine;

namespace UnityEngine
{

public struct CullingGroupEvent
{
    public int currentDistance { get; }
    public bool hasBecomeInvisible { get; }
    public bool hasBecomeVisible { get; }
    public int index { get; }
    public bool isVisible { get; }
    public int previousDistance { get; }
    public bool wasVisible { get; }

}

}
