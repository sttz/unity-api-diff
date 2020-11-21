using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class NavigationEventBase<T> : UIElements.EventBase<T>, UIElements.INavigationEvent
{
    protected NavigationEventBase();

    protected void Init();

}

}
