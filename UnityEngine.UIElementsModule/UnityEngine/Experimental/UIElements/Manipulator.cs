using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class Manipulator : Experimental.UIElements.IManipulator
{
    public Experimental.UIElements.VisualElement target { get; set; }

    protected Manipulator();

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}