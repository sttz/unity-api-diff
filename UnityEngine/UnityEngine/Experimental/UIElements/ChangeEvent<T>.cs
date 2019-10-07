using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ChangeEvent<T> : Experimental.UIElements.EventBase<Experimental.UIElements.ChangeEvent<T>>, Experimental.UIElements.IChangeEvent
{
    static public Experimental.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue);

    public T newValue { get; protected set; }
    public T previousValue { get; protected set; }

    public ChangeEvent();

    protected void Init();

}

}
