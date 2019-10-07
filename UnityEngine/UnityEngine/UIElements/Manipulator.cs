using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class Manipulator : UIElements.IManipulator
{
    public UIElements.VisualElement target { get; set; }

    protected Manipulator();

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
