using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class EventBase<T> : Experimental.UIElements.EventBase
{
    static public T GetPooled();
    static public long TypeId();

    protected EventBase();

    public void Dispose();
    public long GetEventTypeId();
    protected void Init();

}

}
