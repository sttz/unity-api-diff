using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IUIElementDataWatch
{
    public Experimental.UIElements.IUIElementDataWatchRequest RegisterWatch(Object toWatch, Action<Object> watchNotification);
    public void UnregisterWatch(Experimental.UIElements.IUIElementDataWatchRequest requested);

}

}
