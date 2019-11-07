using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class ShortcutHandler : Experimental.UIElements.Manipulator
{
    public ShortcutHandler(System.Collections.Generic.Dictionary<Event, UnityEditor.Experimental.UIElements.GraphView.ShortcutDelegate> dictionary);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
