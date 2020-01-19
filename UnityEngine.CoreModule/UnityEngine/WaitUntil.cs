using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class WaitUntil : CustomYieldInstruction
{
    public bool keepWaiting { get; }

    public WaitUntil(Func<bool> predicate);

}

}
