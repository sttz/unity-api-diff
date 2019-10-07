using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class InputEvent : Experimental.UIElements.EventBase<Experimental.UIElements.InputEvent>
{
    static public Experimental.UIElements.InputEvent GetPooled(string previousData, string newData);

    public string newData { get; protected set; }
    public string previousData { get; protected set; }

    public InputEvent();

    protected void Init();

}

}
