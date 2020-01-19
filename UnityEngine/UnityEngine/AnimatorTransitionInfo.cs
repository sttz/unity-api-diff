using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct AnimatorTransitionInfo
{
    public bool anyState { get; }
    public float duration { get; }
    public DurationUnit durationUnit { get; }
    public int fullPathHash { get; }
    public int nameHash { get; }
    public float normalizedTime { get; }
    public int userNameHash { get; }

    public bool IsName(string name);
    public bool IsUserName(string name);

}

}
