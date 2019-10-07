using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ChangeEvent<T> : UIElements.EventBase<UIElements.ChangeEvent<T>>, UIElements.IChangeEvent
{
    static public UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue);

    public T newValue { get; protected set; }
    public T previousValue { get; protected set; }

    public ChangeEvent();

    protected void Init();

}

}
