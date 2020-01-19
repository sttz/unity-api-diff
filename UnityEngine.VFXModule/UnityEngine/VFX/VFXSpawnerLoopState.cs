using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public enum VFXSpawnerLoopState
{
    Finished = 0,
    DelayingBeforeLoop = 1,
    Looping = 2,
    DelayingAfterLoop = 3,
}

}
