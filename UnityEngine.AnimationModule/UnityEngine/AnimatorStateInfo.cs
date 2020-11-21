using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct AnimatorStateInfo
{
    public int fullPathHash { get; }
    public float length { get; }
    public bool loop { get; }
    public int nameHash { get; }
    public float normalizedTime { get; }
    public int shortNameHash { get; }
    public float speed { get; }
    public float speedMultiplier { get; }
    public int tagHash { get; }

    public bool IsName(string name);
    public bool IsTag(string tag);

}

}
