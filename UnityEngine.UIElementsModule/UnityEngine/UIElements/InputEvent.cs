using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class InputEvent : UIElements.EventBase<UIElements.InputEvent>
{
    static public UIElements.InputEvent GetPooled(string previousData, string newData);

    public string newData { get; protected set; }
    public string previousData { get; protected set; }

    public InputEvent();

    protected void Init();

}

}
