using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngineInternal.Input
{

public enum NativeInputUpdateType
{
    IgnoreFocus = -2147483648,
    Dynamic = 1,
    Fixed = 2,
    BeforeRender = 4,
    Editor = 8,
}

}
