using System;
using UnityEngine;

namespace UnityEngine
{

public abstract class CustomYieldInstruction : System.Collections.IEnumerator
{
    public object Current { get; }
    public bool keepWaiting { get; }

    protected CustomYieldInstruction();

    public bool MoveNext();
    public void Reset();

}

}
