using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum iOSSystemGestureDeferMode : uint
{
    None = 0,
    TopEdge = 1,
    LeftEdge = 2,
    BottomEdge = 4,
    RightEdge = 8,
    All = 15,
}

}
