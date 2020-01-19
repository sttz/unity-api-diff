using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct TimerState : IEquatable<UIElements.TimerState>
{
    public long deltaTime { get; }
    public long now { get; set; }
    public long start { get; set; }

    public bool Equals(object obj);
    public bool Equals(UIElements.TimerState other);
    public int GetHashCode();

}

}
