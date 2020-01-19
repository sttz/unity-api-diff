using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class MouseManipulator : Experimental.UIElements.Manipulator
{
    public List<Experimental.UIElements.ManipulatorActivationFilter> activators { get; private set; }

    protected MouseManipulator();

    protected bool CanStartManipulation(Experimental.UIElements.IMouseEvent e);
    protected bool CanStopManipulation(Experimental.UIElements.IMouseEvent e);

}

}
