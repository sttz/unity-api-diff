using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.LowLevel
{

public struct PlayerLoopSystem
{
    public IntPtr loopConditionFunction;
    public LowLevel.PlayerLoopSystem[] subSystemList;
    public Type type;
    public UpdateFunction updateDelegate;
    public IntPtr updateFunction;

    public delegate void UpdateFunction();

}

}
