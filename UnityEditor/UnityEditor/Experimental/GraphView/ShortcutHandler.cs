using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class ShortcutHandler : UIElements.Manipulator
{
    public ShortcutHandler(System.Collections.Generic.Dictionary<Event, UnityEditor.Experimental.GraphView.ShortcutDelegate> dictionary);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
