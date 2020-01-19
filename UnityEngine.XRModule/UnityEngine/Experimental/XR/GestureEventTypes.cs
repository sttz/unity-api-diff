using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public enum GestureEventTypes : uint
{
    None = 0,
    Hold = 1,
    Manipulation = 2,
    Navigation = 4,
    Recognition = 8,
    Tapped = 16,
    All = 4294967295,
}

}
