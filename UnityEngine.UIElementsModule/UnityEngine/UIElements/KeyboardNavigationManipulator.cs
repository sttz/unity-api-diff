using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class KeyboardNavigationManipulator : UIElements.Manipulator
{
    public KeyboardNavigationManipulator(Action<UIElements.KeyboardNavigationOperation, UIElements.EventBase> action);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
