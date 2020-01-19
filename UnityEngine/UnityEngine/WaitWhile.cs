using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class WaitWhile : CustomYieldInstruction
{
    public bool keepWaiting { get; }

    public WaitWhile(Func<bool> predicate);

}

}
