using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class CustomYieldInstruction : IEnumerator
{
    public object Current { get; }
    public bool keepWaiting { get; }

    protected CustomYieldInstruction();

    public bool MoveNext();
    public void Reset();

}

}
