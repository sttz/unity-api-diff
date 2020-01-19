using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class CommandEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.ICommandEvent, Experimental.UIElements.IPropagatableEvent
{
    static public T GetPooled(string commandName);
    static public T GetPooled(Event systemEvent);

    public string commandName { get; protected set; }

    protected CommandEventBase();

    protected void Init();

}

}
