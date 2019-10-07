using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class WaitUntil : CustomYieldInstruction
{
    public bool keepWaiting { get; }

    public WaitUntil(Func<bool> predicate);

}

}
