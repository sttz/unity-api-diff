using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class ShortcutHandler : Experimental.UIElements.Manipulator
{
    public ShortcutHandler(Dictionary<Event, UnityEditor.Experimental.UIElements.GraphView.ShortcutDelegate> dictionary);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
