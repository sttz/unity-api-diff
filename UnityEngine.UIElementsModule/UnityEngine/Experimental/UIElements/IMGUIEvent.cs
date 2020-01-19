using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class IMGUIEvent : Experimental.UIElements.EventBase<Experimental.UIElements.IMGUIEvent>
{
    static public Experimental.UIElements.IMGUIEvent GetPooled(Event systemEvent);

    public IMGUIEvent();

    protected void Init();

}

}
