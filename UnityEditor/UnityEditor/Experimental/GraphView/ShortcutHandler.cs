using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class ShortcutHandler : UIElements.Manipulator
{
    public ShortcutHandler(Dictionary<Event, UnityEditor.Experimental.GraphView.ShortcutDelegate> dictionary);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}