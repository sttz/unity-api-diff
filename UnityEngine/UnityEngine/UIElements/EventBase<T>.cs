using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class EventBase<T> : UIElements.EventBase
{
    static public T GetPooled();
    static public long TypeId();

    public long eventTypeId { get; }

    protected EventBase();

    public void Dispose();
    protected void Init();

}

}
