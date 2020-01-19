using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public enum FalloffType : byte
{
    InverseSquared = 0,
    InverseSquaredNoRangeAttenuation = 1,
    Linear = 2,
    Legacy = 3,
    Undefined = 4,
}

}
