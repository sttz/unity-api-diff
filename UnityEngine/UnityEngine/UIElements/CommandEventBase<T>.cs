using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class CommandEventBase<T> : UIElements.EventBase<T>, UIElements.ICommandEvent
{
    static public T GetPooled(string commandName);
    static public T GetPooled(Event systemEvent);

    public string commandName { get; protected set; }

    protected CommandEventBase();

    protected void Init();

}

}
