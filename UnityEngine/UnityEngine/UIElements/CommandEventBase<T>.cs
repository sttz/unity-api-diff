using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class CommandEventBase<T> : UIElements.EventBase<T>, UIElements.ICommandEvent
{
    static public T GetPooled(Event systemEvent);
    static public T GetPooled(string commandName);

    public string commandName { get; protected set; }

    protected CommandEventBase();

    protected void Init();

}

}
